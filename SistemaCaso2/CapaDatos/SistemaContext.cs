using SistemaCaso2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SistemaCaso2.CapaDatos
{
    public class SistemaContext : DbContext
    {
        public SistemaContext(): base("SistemaContext")
        {

        }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Enfermedad> Enfermedades { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}