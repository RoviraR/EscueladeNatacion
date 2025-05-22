using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmithSwimmingSchoolApp.Data;
using SmithSwimmingSchoolApp.Models;
using X.PagedList.Extensions;

namespace SmithSwimmingSchoolApp.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class GroupController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GroupController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Group
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.StartDateSortParam = sortOrder == "StartDate" ? "startDate_desc" : "StartDate";
            ViewBag.EndDateSortParam = sortOrder == "EndDate" ? "endDate_desc" : "EndDate";

            ViewBag.CurrentFilter = searchString;

            var groups = from g in _context.Groups select g;

            if (!string.IsNullOrEmpty(searchString))
            {
                groups = groups.Where(g => g.Name.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "StartDate":
                    groups = groups.OrderBy(g => g.Start_Date);
                    break;
                case "startDate_desc":
                    groups = groups.OrderByDescending(g => g.Start_Date);
                    break;
                case "EndDate":
                    groups = groups.OrderBy(g => g.End_Date);
                    break;
                case "endDate_desc":
                    groups = groups.OrderByDescending(g => g.End_Date);
                    break;
                default:
                    groups = groups.OrderBy(g => g.Name);
                    break;
            }

            int pageSize = 5;
            int pageNumber = page ?? 1;

            if (!groups.Any())
            {
                ViewBag.Message = "No hay Grupos con estos filtros.";
            }

            return View(groups.ToPagedList(pageNumber, pageSize));
        }

        // GET: Group/Create
        public IActionResult Create()
        {
            ViewData["GenreList"] = new SelectList(Enum.GetValues(typeof(LevelGroup)).Cast<LevelGroup>()
                .Select(g => new { Id = (int)g, Name = g.ToString() }), "Id", "Name");

            return View();
        }

        // POST: Group/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroupId,Name,Level,Start_Date,End_Date")] Group @group)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@group);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@group);
        }

        // GET: Group/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Groups.FindAsync(id);
            if (@group == null)
            {
                return NotFound();
            }
            return View(@group);
        }

        // POST: Group/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroupId,Name,Level,Start_Date,End_Date")] Group @group)
        {
            if (id != @group.GroupId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@group);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupExists(@group.GroupId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@group);
        }

        // GET: Group/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @group = await _context.Groups
                .FirstOrDefaultAsync(m => m.GroupId == id);
            if (@group == null)
            {
                return NotFound();
            }

            return View(@group);
        }

        // POST: Group/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @group = await _context.Groups.FindAsync(id);
            if (@group != null)
            {
                _context.Groups.Remove(@group);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupExists(int id)
        {
            return _context.Groups.Any(e => e.GroupId == id);
        }
    }
}
