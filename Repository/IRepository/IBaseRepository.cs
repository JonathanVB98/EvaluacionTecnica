using System.Collections.Generic;
using System.Linq;

namespace EvaluacionTecnica.Repository.IRepository
{
    public interface IBaseRepository<E>
    {
        E Add(E entity);
        List<E> AddRange(List<E> entity);
        void Delete(int id);
        IQueryable<E> GetAll();
        E GetById(int id);
        void Update(E entity);
        void UpdateRamge(List<E> entities);
    }
}