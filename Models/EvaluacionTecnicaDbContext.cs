using System.Data.Entity;

namespace EvaluacionTecnica.Models
{
    public class EvaluacionTecnicaDbContext : DbContext
    {
        public EvaluacionTecnicaDbContext() : base("name=MiConexion")
        {
            Configuration.LazyLoadingEnabled = false;
        }
    }
}