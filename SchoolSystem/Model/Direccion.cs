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
    
    public partial class Direccion
    {
        public int ID_Direccion { get; set; }
        public int ID_Estudiante { get; set; }
        public string Calle { get; set; }
        public string Provincia { get; set; }
        public string Municipio { get; set; }
        public string Sector { get; set; }
        public int No_Casa { get; set; }
    
        public virtual Estudiante Estudiante { get; set; }
    }
}
