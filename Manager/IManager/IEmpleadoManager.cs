using EvaluacionTecnica.Models.Dto;
using EvaluacionTecnica.Models.Request;
using EvaluacionTecnica.Models.Response;
using EvaluacionTecnica.Models.Tables;
using System.Collections.Generic;

namespace EvaluacionTecnica.Manager.IManager
{
    public interface IEmpleadoManager : IBaseManager<EmpleadoDto, Empleado>
    {

        List<EmpleadoResponse> ObtenerEmpleados(EmpleadoRequest request);
    }
}