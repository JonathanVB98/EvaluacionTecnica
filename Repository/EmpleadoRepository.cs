using EvaluacionTecnica.Models;
using EvaluacionTecnica.Models.Request;
using EvaluacionTecnica.Models.Response;
using EvaluacionTecnica.Models.Tables;  
using EvaluacionTecnica.Repository.IRepository;
using System;
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

        public List<SucursalesResponse> ObtenerSucursales()
        {
            return context.Sucursal.Where(s => s.EsActivo).Select(s => new SucursalesResponse
            {
                IdSucursal = s.IdSucursal,
                Nombre = s.Nombre + ", " + s.Ciudad.Nombre
            }).ToList();
        }

        public List<EmpleadoResponse> ObtenerEmpleados(EmpleadoRequest request)
        {
            var query = context.Empleado.AsQueryable();

            if (request != null)
            {
                DateTime? fechaFin = request.FechaFin?.Date.AddDays(1);

                query = query.Where(e =>
                    (request.IdEmpleado <= 0 || e.IdEmpleado == request.IdEmpleado) &&
                    (string.IsNullOrEmpty(request.Nombre) ||
                        (e.Nombre + " " + e.Apellidos).Contains(request.Nombre)) &&
                    (!request.FechaInicio.HasValue ||
                        e.FechaIngreso >= request.FechaInicio.Value) &&
                    (!fechaFin.HasValue || e.FechaIngreso < fechaFin.Value) &&
                    (request.IdSucursal <= 0 || e.IdSucursal == request.IdSucursal)
                );
            }

            return query.Select(e => new EmpleadoResponse
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