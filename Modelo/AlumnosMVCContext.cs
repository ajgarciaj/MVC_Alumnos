namespace Modelo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AlumnosMVCContext : DbContext
    {
        public AlumnosMVCContext()
            : base("name=AlumnosMVCContext")
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Curso)
                .WithMany(e => e.Alumno)
                .Map(m => m.ToTable("AlumnoCurso").MapLeftKey("ALUMNO_ID").MapRightKey("CURSO_ID"));

            modelBuilder.Entity<Curso>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);
        }
    }
}
