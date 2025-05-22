using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmithSwimmingSchoolApp.Data;
using SmithSwimmingSchoolApp.Models;

namespace SmithSwimmingSchoolApp.Controllers
{
    [Authorize(Roles = "Coach,Swimmer")]
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ReportProgress(int swimmerId,int courseId)
        {
            var course = await _context.Courses.Include(c => c.Coach).FirstOrDefaultAsync(c => c.CourseId == courseId);
            ViewBag.courseId = course.CourseId;

            var swimmer = await _context.Swimmers.FirstOrDefaultAsync(s => s.SwimmerId == swimmerId);
            ViewBag.Course = course.Title;
            ViewBag.CourseId = course.CourseId;
            ViewBag.Coach = course.Coach.Name;
            ViewBag.Swimmer = swimmer.Name;
            ViewBag.SwimmerId = swimmer.SwimmerId;

            var reports = await _context.Reports
                .Include(r=>r.Enrollment)
                .ThenInclude(e=>e.Swimmer)
                .Include(r => r.Enrollment)
                .ThenInclude(e => e.Course)
                .ThenInclude(e=>e.Coach)
                .Where(r => r.Enrollment.SwimmerId == swimmerId && r.Enrollment.CourseId == courseId)
                .ToListAsync();

            if (reports == null || reports.Count == 0)
            {
                ViewBag.Message = "No hay reportes disponibles para este nadador.";
            }

            return View(reports);
        }
        [Authorize(Roles ="Coach")]
        public async Task<IActionResult> AddReport(int swimmerId, int courseId)
        { 
            var enrollment = await _context.Enrollments.Include(e=>e.Course).Include(e=>e.Swimmer).FirstOrDefaultAsync(e => e.SwimmerId == swimmerId && e.CourseId == courseId);
            ViewData["Reportinfo"] = enrollment;

            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Coach")]
        public async Task<IActionResult> AddReport(Report report)
        {
            if (ModelState.IsValid)
            {
                report.Date = DateTime.Now;
                _context.Reports.Add(report);
                await _context.SaveChangesAsync();

                var enrollment = await _context.Enrollments.FirstOrDefaultAsync(e=>e.EnrollmentId == report.EnrollmentId);

                return RedirectToAction("ReportProgress", new { swimmerId = enrollment.SwimmerId, courseId = enrollment.CourseId } );
            }

            return View();
        }
    }
}
