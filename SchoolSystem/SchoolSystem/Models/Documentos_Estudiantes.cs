//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Documentos_Estudiantes
    {
        public int ID_Documentos { get; set; }
        public int ID_Estudiante { get; set; }
        public byte[] Foto { get; set; }
        public byte[] ActaNacimiento { get; set; }
        public byte[] CertificadoMedico { get; set; }
        public byte[] CertificadoEscorlar { get; set; }
        public byte[] RecordNotas { get; set; }
        public byte[] CopiaCedula { get; set; }
    
        public virtual Estudiante Estudiante { get; set; }
    }
}