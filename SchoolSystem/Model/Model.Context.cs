﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SistemaEscolarEntities : DbContext
    {
        public SistemaEscolarEntities()
            : base("name=SistemaEscolarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Asignar_Tarea> Asignar_Tarea { get; set; }
        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<Documentos_Estudiantes> Documentos_Estudiantes { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Grado> Grado { get; set; }
        public virtual DbSet<Materias> Materias { get; set; }
        public virtual DbSet<Padre_Tutor> Padre_Tutor { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<Registro> Registro { get; set; }
        public virtual DbSet<Subir_Tarea> Subir_Tarea { get; set; }
    }
}
