using EvaluacionTecnica.Models.Dto;
using EvaluacionTecnica.Models.Tables;
using System.Collections.Generic;

namespace EvaluacionTecnica.Repository.IRepository
{
    public interface IRolRepository : IBaseRepository<Rol>
    {
        List<Rol> GetRol();
    }
}