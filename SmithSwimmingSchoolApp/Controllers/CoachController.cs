using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmithSwimmingSchoolApp.Data;
using SmithSwimmingSchoolApp.Models;

namespace SmithSwimmingSchoolApp.Controllers
{
    [Authorize(Roles ="Coach")]
    public class CoachController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoachController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Courses.Where(c=>c.Coach.Email == User.Identity.Name).Include(c => c.Coach).ToListAsync());
        }

        public async Task<IActionResult> EditProfile()
        {
            var coach = await _context!.Coaches.FirstOrDefaultAsync(c=>c.Email == User.Identity.Name);

            if (TempData["Mensaje"] != null)
            {
                ViewBag.Mensaje = TempData["Mensaje"];
            }

            return View(coach);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(Coach coach)
        {
            _context.Coaches.Update(coach);
            await _context.SaveChangesAsync();

            TempData["Mensaje"] = "Datos guardados con éxito.";
            return RedirectToAction("EditProfile");
        }
    }
}
