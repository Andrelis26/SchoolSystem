//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Registro()
        {
            this.Subir_Tarea = new HashSet<Subir_Tarea>();
        }
    
        public int ID_Registro { get; set; }
        public string Rol { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public Nullable<int> ID_Estudiante { get; set; }
    
        public virtual Estudiante Estudiante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subir_Tarea> Subir_Tarea { get; set; }
    }
}
