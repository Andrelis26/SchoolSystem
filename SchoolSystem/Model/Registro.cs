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
        public byte[] Contraseña { get; set; }
        public Nullable<int> ID_Estudiante { get; set; }
    
        public virtual Estudiante Estudiante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subir_Tarea> Subir_Tarea { get; set; }
    }
}
