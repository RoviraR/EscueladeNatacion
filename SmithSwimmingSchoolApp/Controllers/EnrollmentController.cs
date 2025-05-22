using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmithSwimmingSchoolApp.Data;
using SmithSwimmingSchoolApp.Models;
using SmithSwimmingSchoolApp.ViewModels;

namespace SmithSwimmingSchoolApp.Controllers
{
    [Authorize(Roles = "Administrator,Swimmer")]
    public class EnrollmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EnrollmentController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Swimmer")]
        public async Task<IActionResult> EnrollSwimmer(int CourseId)
        {
            var swimmer = await _context.Swimmers.Where(s => s.Email == User.Identity.Name).FirstOrDefaultAsync();
            var course = await _context.Courses.Where(c => c.CourseId == CourseId).FirstOrDefaultAsync();

            ViewBag.Swimmer = swimmer.Name;
            ViewBag.SwimmerId = swimmer.SwimmerId;
            ViewBag.Course = course.Title;
            ViewBag.CourseId = course.CourseId;

            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Swimmer")]
        public async Task<IActionResult> EnrollSwimmer(Enrollment enrollment)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(c => c.CourseId == enrollment.CourseId);

            if(course.Places < 1)
            {
                ViewBag.Course = course.Title;
                return View("NoPlaces");
            }

            course.Places--;
            _context.Update(course);

            _context.Add(enrollment);
            await _context.SaveChangesAsync();

            return RedirectToAction("SwimmerCourses","Swimmers",enrollment.SwimmerId);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> AssignGroup(int SwimmerId, int CourseId, int GroupId)
        {
            var enrollment = await _context.Enrollments
                .FirstOrDefaultAsync(e => e.SwimmerId == SwimmerId && e.CourseId == CourseId);

            if (enrollment == null)
            {
                return NotFound("Matrícula no encontrada.");
            }

            enrollment.GroupId = GroupId;
            await _context.SaveChangesAsync();

            return RedirectToAction("CourseDetails","Course", new { id = CourseId });
        }
    }
}
