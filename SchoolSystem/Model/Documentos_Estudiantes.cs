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
