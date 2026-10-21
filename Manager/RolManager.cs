using EvaluacionTecnica.Manager.IManager;
using EvaluacionTecnica.Models.Dto;
using EvaluacionTecnica.Models.Tables;
using EvaluacionTecnica.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Manager
{
    public class RolManager : BaseManager<RolDto, Rol>, IRolManager
    {
        public readonly IRolRepository _rolRepository;

        public RolManager(IRolRepository repository) : base(repository)
        {
            _rolRepository = repository;
        }

        public override Rol AddConvert(RolDto viewModel)
        {
            return new Rol()
            {
                RolId = viewModel.RolId,
                Name = viewModel.Name,
                IsActive = viewModel.IsActive,
                CreateDate = viewModel.CreateDate
            };
        }

        public override Rol UpdatedConverter(RolDto viewModel, Rol entity)
        {
            entity.Name = viewModel.Name;
            entity.IsActive = viewModel.IsActive;
            entity.CreateDate = viewModel.CreateDate;

            return entity;
        }

        public override RolDto SingleConverter(Rol entity)
        {
            return new RolDto()
            {
                Name = entity.Name,
                IsActive = entity.IsActive
            };
        }

        public override List<RolDto> CollectionConverter(List<Rol> entities)
        {
            return entities.Select(p => new RolDto()
            {
                Name = p.Name,
                IsActive = p.IsActive
            }).ToList();
        }
    }
}