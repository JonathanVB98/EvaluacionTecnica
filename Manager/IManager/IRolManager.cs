using EvaluacionTecnica.Models.Dto;
using EvaluacionTecnica.Models.Tables;
using System.Collections.Generic;

namespace EvaluacionTecnica.Manager.IManager
{
    public interface IRolManager : IBaseManager<RolDto, Rol>
    {
        List<RolDto> GetRol();
    }
}