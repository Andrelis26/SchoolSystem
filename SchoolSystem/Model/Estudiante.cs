//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Estudiante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estudiante()
        {
            this.Direccion = new HashSet<Direccion>();
            this.Documentos_Estudiantes = new HashSet<Documentos_Estudiantes>();
            this.Padre_Tutor = new HashSet<Padre_Tutor>();
        }
    
        public int ID_Estudiante { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Primer Nombre")]
        [MaxLength(50)]
        public string Primer_Nombre { get; set; }

        [Display(Name = "Segundo Nombre")]
        [MaxLength(50)]
        public string Segundo_Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Primer Apellido")]
        [MaxLength(50)]
        public string Primer_Apellido { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Segundo Apellido")]
        [MaxLength(50)]
        public string Segundo_Apelido { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public System.DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(1, 150)]
        public short Edad { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(50)]
        public string Nacionalidad { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Grado que Solicita")]
        public int ID_Grado { get; set; }

        [Display(Name = "Centro Educativo")]
        [MaxLength(100)]
        public string CentroEducativo { get; set; }

        [Display(Name = "Último grado cursado")]
        [MaxLength(50)]
        public string GradoSolicita { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Distrito Educativo")]
        [MaxLength(50)]
        public string DistritoEducativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Direccion> Direccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentos_Estudiantes> Documentos_Estudiantes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Padre_Tutor> Padre_Tutor { get; set; }
        public virtual Grado Grado { get; set; }
    }
}
