using Microsoft.EntityFrameworkCore;
using webappacademica1.Models;

namespace webappacademica1.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Alumno>().HasKey(a => a.idAlumno);
        }
        public DbSet<webappacademica1.Models.Docente> Docente { get; set; } = default!;
        public DbSet<webappacademica1.Models.Materia> Materia { get; set; } = default!;
        public DbSet<webappacademica1.Models.Periodo> Periodo { get; set; } = default!;
        public DbSet<webappacademica1.Models.Matricula> Matricula { get; set; } = default!;
    }
}
