using api_softtek.Common_Layer.Models;
using Microsoft.EntityFrameworkCore;

namespace api_softtek.DAL
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

            
        }


       public DbSet<Carrera> Carreras { get; set; }

       public DbSet<Estudiante> Estudiantes { get; set; }

        public DbSet<Materia> Materias { get; set; }

        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Nota> Notas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nota>()
                .HasKey(n => new { n.EstudianteId, n.MateriaId });
            modelBuilder.Entity<Nota>()
                  .HasOne(n => n.Estudiante)
                  .WithMany()
                  .HasForeignKey(n => n.EstudianteId)
                  .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Nota>()
                .HasOne(n => n.Materia)
                .WithMany()
                .HasForeignKey(n => n.MateriaId)
                .OnDelete(DeleteBehavior.Cascade);
            // Other configurations...

            base.OnModelCreating(modelBuilder);
        }



    }
}
