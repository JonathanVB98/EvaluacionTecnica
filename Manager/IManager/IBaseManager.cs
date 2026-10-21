using System;
using System.Collections.Generic;
using QueryParameter = EvaluacionTecnica.Utils.QueryParameter;

namespace EvaluacionTecnica.Manager.IManager
{
    public interface IBaseManager<VM, E> where VM : class where E : class
    {
        VM Add(VM state);

        void Delete(int id);

        Tuple<List<VM>, Utils.PagedResult<E>> GetAll(QueryParameter pagingParameter, Filters.IFilter filter);

        VM GetById(int id);

        void Update(int id, VM state);
    }
}