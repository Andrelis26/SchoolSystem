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
    
    public partial class Materias
    {
        public int ID_Materia { get; set; }
        public string Descripcion { get; set; }
        public int ID_Grado { get; set; }
    
        public virtual Grado Grado { get; set; }
    }
}
