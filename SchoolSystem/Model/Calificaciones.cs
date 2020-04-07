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
    
    public partial class Calificaciones
    {
        public int Id { get; set; }
        public int Id_Estudiante { get; set; }
        public int Id_Materia { get; set; }
        public int Id_Profesor { get; set; }

        [Required(ErrorMessage = "Debe especificar una calificación")]
        [Display(Name = "Calificación")]
        [Range(0, 100)]
        public decimal Nota { get; set; }

        public virtual Materias Materias { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual Estudiante Estudiante { get; set; }
    }
}
