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
    
    public partial class Subir_Tarea
    {
        public int ID_Tarea { get; set; }
        public Nullable<int> ID_Estudiante { get; set; }
        public byte[] Tarea { get; set; }
        public Nullable<int> ID_Materia { get; set; }
        public Nullable<int> Id_TareaAsignada { get; set; }
    
        public virtual Asignar_Tarea Asignar_Tarea { get; set; }
        public virtual Materias Materias { get; set; }
        public virtual Registro Registro { get; set; }
    }
}
