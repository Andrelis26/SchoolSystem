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
    
    public partial class Estudiante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estudiante()
        {
            this.Direccion = new HashSet<Direccion>();
            this.Documentos_Estudiantes = new HashSet<Documentos_Estudiantes>();
            this.Padre_Tutor = new HashSet<Padre_Tutor>();
            this.Registro = new HashSet<Registro>();
        }
    
        public int ID_Estudiante { get; set; }
        public string Primer_Nombre { get; set; }
        public string Segundo_Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apelido { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public short Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string Sexo { get; set; }
        public int ID_Grado { get; set; }
        public string CentroEducativo { get; set; }
        public string Nivel { get; set; }
        public string GradoSolicita { get; set; }
        public string DistritoEducativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Direccion> Direccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentos_Estudiantes> Documentos_Estudiantes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Padre_Tutor> Padre_Tutor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro> Registro { get; set; }
        public virtual Grado Grado { get; set; }
    }
}
