using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmithSwimmingSchoolApp.Data;
using SmithSwimmingSchoolApp.Models;
using X.PagedList.Extensions;

namespace SmithSwimmingSchoolApp.Controllers
{
    [Authorize(Roles = "Administrator, Swimmer")]
    public class SwimmersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public SwimmersController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Swimmers
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParam = sortOrder == "name_desc" ? "name_asc" : "name_desc";

            ViewBag.CurrentFilter = searchString;

            var swimmers = from s in _context.Swimmers select s;

            if (!string.IsNullOrEmpty(searchString))
            {
                swimmers = swimmers.Where(s => s.Name.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_asc":
                    swimmers = swimmers.OrderBy(s => s.Name);
                    break;
                case "name_desc":
                    swimmers = swimmers.OrderByDescending(s => s.Name);
                    break;
            }

            int pageSize = 5;
            int pageNumber = page ?? 1;

            if (!swimmers.Any())
            {
                ViewBag.Message = "No hay Nadadores con estos filtros.";
            }

            return View(swimmers.ToPagedList(pageNumber, pageSize));
        }

        // GET: Swimmers/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var swimmer = await _context.Swimmers.FindAsync(id);
            if (swimmer == null)
            {
                return NotFound();
            }

            ViewData["GenreList"] = new SelectList(Enum.GetValues(typeof(GenreSwimmer)).Cast<GenreSwimmer>()
                .Select(g => new { Id = (int)g, Name = g.ToString() }),"Id", "Name", swimmer.Genre);

            return View(swimmer);
        }

        // POST: Swimmers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id, [Bind("SwimmerId,Name,Phone_Number,Email,Genre,Birth_Date")] Swimmer swimmer)
        {
            if (id != swimmer.SwimmerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(swimmer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SwimmerExists(swimmer.SwimmerId))
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
            return View(swimmer);
        }

        // GET: Swimmers/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Desactive(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var swimmer = await _context.Swimmers
                .FirstOrDefaultAsync(m => m.SwimmerId == id);
            if (swimmer == null)
            {
                return NotFound();
            }

            return View(swimmer);
        }

        // POST: Swimmers/Delete/5
        [HttpPost, ActionName("Desactive")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DesactiveConfirmed(int id)
        {
            var swimmer = await _context.Swimmers.FindAsync(id);
            if (swimmer != null)
            {
                swimmer.IsActive = false;
            }

            var user = await _userManager.FindByEmailAsync(swimmer.Email);
            if (user != null)
            {
                user.EmailConfirmed = false;

                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    // Manejar errores de eliminación, si es necesario
                    ModelState.AddModelError(string.Empty, "No se pudo desactivar el usuario.");
                    return View(swimmer);
                }
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Active(int? id)
        {
            var swimmer = await _context.Swimmers.FirstOrDefaultAsync(m => m.SwimmerId == id);

            swimmer.IsActive = true;

            _context.Update(swimmer);

            var user = await _userManager.FindByEmailAsync(swimmer.Email);
            if (user != null)
            {
                user.EmailConfirmed = true;

                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    // Manejar errores de eliminación, si es necesario
                    ModelState.AddModelError(string.Empty, "No se pudo activar el usuario.");
                    return RedirectToAction(nameof(Index));
                }
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool SwimmerExists(int id)
        {
            return _context.Swimmers.Any(e => e.SwimmerId == id);
        }
        [Authorize(Roles = "Swimmer")]
        public async Task<IActionResult> SwimmerCourses()
        {
            var swimmer = await _context!.Swimmers?.FirstOrDefaultAsync(s => s.Email == User.Identity.Name);

            var courses = await _context.Enrollments.Where(e => e.SwimmerId == swimmer.SwimmerId).Include(e=>e.Group).Include(e => e.Course).ThenInclude(e=>e.Coach).ToListAsync();

            ViewBag.SwimmerId = swimmer?.SwimmerId;

            return View(courses);
        }
    }
}
