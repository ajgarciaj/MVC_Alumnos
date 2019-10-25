namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Alumno")]
    public partial class Alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alumno()
        {
            Curso = new HashSet<Curso>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(250)]
        public string APELLIDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Curso> Curso { get; set; }

        public List<Alumno> Listar()
        {
            var alumnos = new List<Alumno>();
            try
            {
                using (var context = new AlumnosMVCContext())
                {
                    alumnos = context.Alumno.ToList();
                }
            }
            catch (Exception e)
            {
                throw;

            }
            return alumnos;
        }
    }
}
