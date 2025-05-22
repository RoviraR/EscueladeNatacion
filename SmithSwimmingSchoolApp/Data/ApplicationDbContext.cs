using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmithSwimmingSchoolApp.Models;
using System.Data;

namespace SmithSwimmingSchoolApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Swimmer> Swimmers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for models
            modelBuilder.Entity<Swimmer>().HasData(
                new Swimmer { SwimmerId = 1, Name = "Juan Pérez", Phone_Number = "555123456", Email = "juanperez@ejemplo.com", Genre = GenreSwimmer.Masculino, Birth_Date = new DateTime(2000, 1, 1) },
                new Swimmer { SwimmerId = 2, Name = "Ana Gómez", Phone_Number = "555654321", Email = "anagomez@ejemplo.com", Genre = GenreSwimmer.Femenino, Birth_Date = new DateTime(1995, 5, 15) },
                new Swimmer { SwimmerId = 3, Name = "Luis Fernández", Phone_Number = "444555666", Email = "luis.fernandez@ejemplo.com", Genre = GenreSwimmer.Masculino, Birth_Date = new DateTime(1988, 3, 22) },
                new Swimmer { SwimmerId = 4, Name = "María Torres", Phone_Number = "777888999", Email = "maria.torres@ejemplo.com", Genre = GenreSwimmer.Femenino, Birth_Date = new DateTime(2002, 7, 10) },
                new Swimmer { SwimmerId = 5, Name = "Carlos Ruiz", Phone_Number = "888777666", Email = "carlos.ruiz@ejemplo.com", Genre = GenreSwimmer.Masculino, Birth_Date = new DateTime(1999, 12, 15) },
                new Swimmer { SwimmerId = 6, Name = "Lucía Ramírez", Phone_Number = "333444555", Email = "lucia.ramirez@ejemplo.com", Genre = GenreSwimmer.Femenino, Birth_Date = new DateTime(1996, 8, 25) },
                new Swimmer { SwimmerId = 7, Name = "Pedro Gutiérrez", Phone_Number = "111222444", Email = "pedro.gutierrez@ejemplo.com", Genre = GenreSwimmer.Masculino, Birth_Date = new DateTime(1985, 6, 5) },
                new Swimmer { SwimmerId = 8, Name = "Sofía Moreno", Phone_Number = "555666888", Email = "sofia.moreno@ejemplo.com", Genre = GenreSwimmer.Femenino, Birth_Date = new DateTime(1994, 11, 30) }
            );

            modelBuilder.Entity<Coach>().HasData(
                new Coach { CoachId = 1, Name = "José García", Phone_Number = "1234567890", Email = "jose.garcia@ejemplo.com" },
                new Coach { CoachId = 2, Name = "María Pérez", Phone_Number = "9876543210", Email = "maria.perez@ejemplo.com" },
                new Coach { CoachId = 3, Name = "Carlos Sánchez", Phone_Number = "2223334444", Email = "carlos.sanchez@ejemplo.com" },
                new Coach { CoachId = 4, Name = "Laura Martínez", Phone_Number = "5556667777", Email = "laura.martinez@ejemplo.com" },
                new Coach { CoachId = 5, Name = "Miguel Hernández", Phone_Number = "8889990000", Email = "miguel.hernandez@ejemplo.com" },
                new Coach { CoachId = 6, Name = "Sofía López", Phone_Number = "1112223333", Email = "sofia.lopez@ejemplo.com" }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, Title = "Braza", CoachId = 1, Places = 10 },
                new Course { CourseId = 2, Title = "Flotación y Propulsión", CoachId = 2, Places = 15 },
                new Course { CourseId = 3, Title = "Mariposa", CoachId = 3, Places = 12 },
                new Course { CourseId = 4, Title = "Crol", CoachId = 4, Places = 18 },
                new Course { CourseId = 5, Title = "Resistencia en Aguas Abiertas", CoachId = 5, Places = 8 },
                new Course { CourseId = 6, Title = "Técnica de Espalda", CoachId = 6, Places = 20 }
            );

            modelBuilder.Entity<Group>().HasData(
                new Group { GroupId = 1, Name = "Braza Mañana", Level = LevelGroup.Principiante, Start_Date = DateTime.Now.AddDays(-10), End_Date = DateTime.Now.AddDays(20) },
                new Group { GroupId = 2, Name = "Braza Tarde", Level = LevelGroup.Intermedio, Start_Date = DateTime.Now.AddDays(-5), End_Date = DateTime.Now.AddDays(25) },
                new Group { GroupId = 3, Name = "Flotación y Propulsión Mañana", Level = LevelGroup.Principiante, Start_Date = DateTime.Now.AddDays(-8), End_Date = DateTime.Now.AddDays(22) },
                new Group { GroupId = 4, Name = "Flotación y Propulsión Tarde", Level = LevelGroup.Avanzado, Start_Date = DateTime.Now.AddDays(-2), End_Date = DateTime.Now.AddDays(28) },
                new Group { GroupId = 5, Name = "Mariposa Mañana", Level = LevelGroup.Principiante, Start_Date = DateTime.Now, End_Date = DateTime.Now.AddDays(30) },
                new Group { GroupId = 6, Name = "Mariposa Tarde", Level = LevelGroup.Intermedio, Start_Date = DateTime.Now.AddDays(3), End_Date = DateTime.Now.AddDays(33) },
                new Group { GroupId = 7, Name = "Crol Mañana", Level = LevelGroup.Intermedio, Start_Date = DateTime.Now.AddDays(1), End_Date = DateTime.Now.AddDays(31) },
                new Group { GroupId = 8, Name = "Crol Tarde", Level = LevelGroup.Avanzado, Start_Date = DateTime.Now.AddDays(7), End_Date = DateTime.Now.AddDays(37) }
            );

            modelBuilder.Entity<Enrollment>().HasData(
                new Enrollment { EnrollmentId = 1, CourseId = 1, SwimmerId = 1, GroupId = 1 },
                new Enrollment { EnrollmentId = 2, CourseId = 1, SwimmerId = 2, GroupId = 2 },
                new Enrollment { EnrollmentId = 3, CourseId = 2, SwimmerId = 3, GroupId = 3 },
                new Enrollment { EnrollmentId = 4, CourseId = 2, SwimmerId = 4, GroupId = 4 },
                new Enrollment { EnrollmentId = 5, CourseId = 3, SwimmerId = 5, GroupId = 5 },
                new Enrollment { EnrollmentId = 6, CourseId = 3, SwimmerId = 6, GroupId = 6 },
                new Enrollment { EnrollmentId = 7, CourseId = 4, SwimmerId = 7, GroupId = 7 },
                new Enrollment { EnrollmentId = 8, CourseId = 4, SwimmerId = 8, GroupId = 8 }
            );

            modelBuilder.Entity<Report>().HasData(
                new Report { ReportId = 1, Content = "Buen progreso, ¡sigue practicando!", EnrollmentId = 1, Date = new DateTime(2024, 12, 1) },
                new Report { ReportId = 2, Content = "Necesita mejorar la técnica, se requiere más práctica.", EnrollmentId = 2, Date = new DateTime(2024, 12, 2) },
                new Report { ReportId = 3, Content = "Excelente avance en el curso, sigue así.", EnrollmentId = 3, Date = new DateTime(2024, 12, 3) },
                new Report { ReportId = 4, Content = "Algunos problemas con la flotación, se recomienda reforzar.", EnrollmentId = 3, Date = new DateTime(2024, 12, 4) },
                new Report { ReportId = 5, Content = "Gran desempeño en las clases, buen trabajo.", EnrollmentId = 4, Date = new DateTime(2024, 12, 5) },
                new Report { ReportId = 6, Content = "Dificultades en la técnica de brazada, trabajar en ello.", EnrollmentId = 5, Date = new DateTime(2024, 12, 6) },
                new Report { ReportId = 7, Content = "Muestra mejoría constante en las sesiones.", EnrollmentId = 5, Date = new DateTime(2024, 12, 7) },
                new Report { ReportId = 8, Content = "Progreso notable en el nado mariposa.", EnrollmentId = 6, Date = new DateTime(2024, 12, 8) },
                new Report { ReportId = 9, Content = "Problemas menores con la técnica, mejorar coordinación.", EnrollmentId = 7, Date = new DateTime(2024, 12, 9) },
                new Report { ReportId = 10, Content = "Desempeño sobresaliente, excelente actitud.", EnrollmentId = 8, Date = new DateTime(2024, 12, 10) }
            );
        }

        public static async Task SeedRolesAndUsers(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            // Roles to seed
            var roles = new[] { "Administrator", "Coach", "Swimmer" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            // Users to seed
            var users = new[]
            {
                // Administrator
                new { Email = "admin@ejemplo.com", Password = "Admin@123", Role = "Administrator" },

                // Coaches
                new { Email = "jose.garcia@ejemplo.com", Password = "Coach@123", Role = "Coach" },
                new { Email = "maria.perez@ejemplo.com", Password = "Coach@123", Role = "Coach" },
                new { Email = "carlos.sanchez@ejemplo.com", Password = "Coach@123", Role = "Coach" },
                new { Email = "laura.martinez@ejemplo.com", Password = "Coach@123", Role = "Coach" },
                new { Email = "miguel.hernandez@ejemplo.com", Password = "Coach@123", Role = "Coach" },
                new { Email = "sofia.lopez@ejemplo.com", Password = "Coach@123", Role = "Coach" },

                // Swimmers
                new { Email = "juanperez@ejemplo.com", Password = "Swimmer@123", Role = "Swimmer" },
                new { Email = "anagomez@ejemplo.com", Password = "Swimmer@123", Role = "Swimmer" },
                new { Email = "luis.fernandez@ejemplo.com", Password = "Swimmer@123", Role = "Swimmer" },
                new { Email = "maria.torres@ejemplo.com", Password = "Swimmer@123", Role = "Swimmer" },
                new { Email = "carlos.ruiz@ejemplo.com", Password = "Swimmer@123", Role = "Swimmer" },
                new { Email = "lucia.ramirez@ejemplo.com", Password = "Swimmer@123", Role = "Swimmer" },
                new { Email = "pedro.gutierrez@ejemplo.com", Password = "Swimmer@123", Role = "Swimmer" },
                new { Email = "sofia.moreno@ejemplo.com", Password = "Swimmer@123", Role = "Swimmer" }
            };

            foreach (var user in users)
            {
                if (await userManager.FindByEmailAsync(user.Email) == null)
                {
                    var newUser = new IdentityUser { UserName = user.Email, Email = user.Email, EmailConfirmed = true };
                    var result = await userManager.CreateAsync(newUser, user.Password);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(newUser, user.Role);
                    }
                }
            }
        }
    }
}
