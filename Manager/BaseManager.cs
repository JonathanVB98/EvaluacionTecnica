using EvaluacionTecnica.Manager.IManager;
using EvaluacionTecnica.Repository.IRepository;
using EvaluacionTecnica.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QueryParameter = EvaluacionTecnica.Utils.QueryParameter;

namespace EvaluacionTecnica.Manager
{
    public class BaseManager<VM, E> : IBaseManager<VM, E> where VM : class where E : class
    {
        public readonly IBaseRepository<E> _repository;

        public BaseManager(IBaseRepository<E> repository)
        {
            _repository = repository;
        }

        public virtual VM Add(VM viewModel)
        {
            E entity = this.AddConvert(viewModel);

            _repository.Add(entity);

            return viewModel;
        }

        public virtual void Delete(int id)
        {
            _repository.Delete(id);
        }

        public virtual Tuple<List<VM>, Utils.PagedResult<E>> GetAll(QueryParameter pagingParameter, Filters.IFilter filter)
        {
            var source = _repository.GetAll().GetPaged(pagingParameter, filter);
            var resources = CollectionConverter(source.Results.ToList());

            source.Results = null;
            return new Tuple<List<VM>, Utils.PagedResult<E>>(resources, source);
        }

        public virtual VM GetById(int id)
        {
            E entity = _repository.GetById(id);

            return this.SingleConverter(entity);
        }

        public virtual void Update(int id, VM viewModel)
        {
            E entity = _repository.GetById(id);

            if (entity == null)
            {
                throw new Exception("No se encontro el registro");
            }

            entity = this.UpdatedConverter(viewModel, entity);

            _repository.Update(entity);
        }

        public virtual E AddConvert(VM viewModel)
        {
            throw new NotImplementedException();
        }
        public virtual E UpdatedConverter(VM viewModel, E entity)
        {
            throw new NotImplementedException();
        }
        public virtual VM SingleConverter(E entity)
        {
            throw new NotImplementedException();
        }
        public virtual List<VM> CollectionConverter(List<E> entities)
        {
            throw new NotImplementedException();
        }
    }
}