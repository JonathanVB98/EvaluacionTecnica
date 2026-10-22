using EvaluacionTecnica.Models.Request;
using EvaluacionTecnica.Models.Response;
using EvaluacionTecnica.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Repository.IRepository
{
    public interface IEmpleadoRepository : IBaseRepository<Empleado>
    {
        List<EmpleadoResponse> ObtenerEmpleados(EmpleadoRequest request);
        List<SucursalesResponse> ObtenerSucursales();

    }
}