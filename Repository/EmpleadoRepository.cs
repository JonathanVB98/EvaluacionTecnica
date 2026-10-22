using EvaluacionTecnica.Models;
using EvaluacionTecnica.Models.Response;
using EvaluacionTecnica.Models.Tables;  
using EvaluacionTecnica.Repository.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace EvaluacionTecnica.Repository
{
    public class EmpleadoRepository : BaseRepository<Empleado>, IEmpleadoRepository
    {
        protected readonly EvaluacionTecnicaDbContext context;
        public EmpleadoRepository(EvaluacionTecnicaDbContext context) : base(context)
        {
            this.context = context;
        }


        public List<EmpleadoResponse> ObtenerEmpleados()
        {
            return context.Empleado.Select(e => new EmpleadoResponse
            {
                IdEmpleado = e.IdEmpleado,
                Nombre = e.Nombre + " " + e.Apellidos,
                Direccion = e.Direccion,
                Edad = e.Edad,
                Telefono = e.Telefono,
                FechaIngreso = e.FechaIngreso,
                Genero = e.Sexo.Nombre,
                Salario = e.Salario,
                Sucursal = e.Sucursal.Nombre + ", " + e.Sucursal.Ciudad.Nombre
            }).ToList();
        }
    }
}