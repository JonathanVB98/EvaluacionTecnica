using EvaluacionTecnica.Manager.IManager;
using EvaluacionTecnica.Models.Dto;
using EvaluacionTecnica.Models.Response;
using EvaluacionTecnica.Models.Tables;
using EvaluacionTecnica.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Manager
{
    public class EmpleadoManager : BaseManager<EmpleadoDto, Empleado>, IEmpleadoManager
    {
        public readonly IEmpleadoRepository _empleadoRepository;
        public EmpleadoManager(IEmpleadoRepository repository) : base(repository)
        {
            _empleadoRepository = repository;
        }
        public override Empleado AddConvert(EmpleadoDto viewModel)
        {
            return new Empleado()
            {
                IdEmpleado = viewModel.IdEmpleado,
                Nombre = viewModel.Nombre,
                Apellidos = viewModel.Apellidos,
                Direccion = viewModel.Direccion,
                Edad = viewModel.Edad,
                Telefono = viewModel.Telefono,
                IdSexo = viewModel.IdSexo,
                FechaIngreso = viewModel.FechaIngreso,
                Salario = viewModel.Salario,
                IdSucursal = viewModel.IdSucursal,
            };
        }
        public override Empleado UpdatedConverter(EmpleadoDto viewModel, Empleado entity)
        {
            entity.Nombre = viewModel.Nombre;
            entity.Apellidos = viewModel.Apellidos;
            entity.Direccion = viewModel.Direccion;
            entity.Edad = viewModel.Edad;
            entity.Telefono = viewModel.Telefono;
            entity.IdSexo = viewModel.IdSexo;
            entity.FechaIngreso = viewModel.FechaIngreso;
            return entity;
        }
        public override EmpleadoDto SingleConverter(Empleado entity)
        {
            return new EmpleadoDto()
            {
                Nombre = entity.Nombre,
                Apellidos = entity.Apellidos,
                Direccion = entity.Direccion,
                Edad = entity.Edad,
                Telefono = entity.Telefono,
                IdSexo = entity.IdSexo,
                FechaIngreso = entity.FechaIngreso,
                Salario = entity.Salario,
                IdSucursal = entity.IdSucursal
            };
        }
        public override List<EmpleadoDto> CollectionConverter(List<Empleado> entities)
        {
            return entities.Select(p => new EmpleadoDto()
            {
                Nombre = p.Nombre,
                Apellidos = p.Apellidos,
                Direccion = p.Direccion,
                Edad = p.Edad,
                Telefono = p.Telefono,
                IdSexo = p.IdSexo,
                FechaIngreso = p.FechaIngreso,
                Salario = p.Salario,
                IdSucursal = p.IdSucursal
            }).ToList();
        }

        public List<EmpleadoResponse> ObtenerEmpleados()
        {
            return _empleadoRepository.ObtenerEmpleados();
        }
    }
}