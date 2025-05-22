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
using SmithSwimmingSchoolApp.ViewModels;
using X.PagedList.Extensions;

namespace SmithSwimmingSchoolApp.Controllers
{
    [Authorize(Roles = "Administrator, Coach, Swimmer")]
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Course
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            if (User.IsInRole("Swimmer"))
            {
                ViewBag.SwimmerId = await _context.Swimmers.Where(s=>s.Email == User.Identity.Name).Select(s=>s.SwimmerId).FirstOrDefaultAsync();
                ViewData["enrollments"] = await _context.Enrollments.ToListAsync();
            }

            ViewBag.CurrentSort = sortOrder;
            ViewBag.PlacesSortParam = sortOrder == "Places" ? "places_desc" : "Places";

            ViewBag.CurrentFilter = searchString;

            var courses = from c in _context.Courses.Include(c => c.Coach) select c;

            if (!string.IsNullOrEmpty(searchString))
            {
                courses = courses.Where(c => c.Title.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "Places":
                    courses = courses.OrderBy(c => c.Places);
                    break;
                case "places_desc":
                    courses = courses.OrderByDescending(c => c.Places);
                    break;
            }

            int pageSize = 5;
            int pageNumber = page ?? 1;

            if (!courses.Any())
            {
                ViewBag.Message = "No hay Cursos con estos filtros.";
            }

            return View(courses.ToPagedList(pageNumber, pageSize));
        }

        // GET: Course/Create
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            ViewData["CoachId"] = new SelectList(_context.Coaches, "CoachId", "Name");
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("CourseId,Title,CoachId,Places")] Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CoachId"] = new SelectList(_context.Coaches, "CoachId", "Name", course.CoachId);
            return View(course);
        }

        // GET: Course/Edit/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            ViewData["CoachId"] = new SelectList(_context.Coaches, "CoachId", "Name", course.CoachId);
            return View(course);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id, [Bind("CourseId,Title,CoachId,Places")] Course course)
        {
            if (id != course.CourseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.CourseId))
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
            ViewData["CoachId"] = new SelectList(_context.Coaches, "CoachId", "Name", course.CoachId);
            return View(course);
        }

        // GET: Course/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.Coach)
                .FirstOrDefaultAsync(m => m.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.CourseId == id);
        }

        public async Task<IActionResult> CourseDetails(int id)
        {
            // Buscar el curso por ID e incluir los nadadores relacionados y sus grupos
            var course = await _context.Courses
                .Where(c => c.CourseId == id)
                .Include(c => c.Coach)
                .Include(c => c.Enrollments!)
                    .ThenInclude(e => e.Swimmer)
                .Include(c => c.Enrollments!)
                    .ThenInclude(e => e.Group) // Incluir los grupos
                .FirstOrDefaultAsync();

            if (course == null)
            {
                return NotFound();
            }

            var groups = await _context.Groups.ToListAsync(); // Obtener todos los grupos
            ViewBag.Groups = groups; // Pasar grupos a la vista

            // Crear un ViewModel para mostrar los detalles del curso y nadadores
            var courseDetails = new CourseDetailsViewModel
            {
                CourseId = course.CourseId,
                Title = course.Title,
                CoachName = course.Coach?.Name,
                Places = course.Places,
                Swimmers = course.Enrollments?.Select(e => new SwimmerDetails
                {
                    SwimmerId = e.Swimmer?.SwimmerId ?? 0,
                    Name = e.Swimmer?.Name,
                    Genre = e.Swimmer!.Genre,
                    Birth_Date = e.Swimmer?.Birth_Date,
                    IsActive = e.Swimmer.IsActive,
                    GroupName = e.Group?.Name ?? "Pendiente de Asignación" // Asignar nombre del grupo o texto predeterminado
                }).ToList()
            };

            return View(courseDetails);
        }
    }
}
