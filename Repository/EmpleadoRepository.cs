using EvaluacionTecnica.Models;
using EvaluacionTecnica.Models.Tables;  
using EvaluacionTecnica.Repository.IRepository;

namespace EvaluacionTecnica.Repository
{
    public class EmpleadoRepository : BaseRepository<Empleado>, IEmpleadoRepository
    {
        protected readonly EvaluacionTecnicaDbContext context;
        public EmpleadoRepository(EvaluacionTecnicaDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}