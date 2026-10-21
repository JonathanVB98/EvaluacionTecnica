using EvaluacionTecnica.Models.Tables;
using System.Data.Entity;

namespace EvaluacionTecnica.Models
{
    public class EvaluacionTecnicaDbContext : DbContext
    {
        public EvaluacionTecnicaDbContext() : base("name=MiConexion")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Sexo> Sexo { get; set; }
        public virtual DbSet<Sucursal> Sucursal { get; set; }
    }
}