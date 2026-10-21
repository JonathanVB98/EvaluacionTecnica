using EvaluacionTecnica.Models;
using EvaluacionTecnica.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using EvaluacionTecnica.Utils;
using System.Data.Entity.Migrations;

namespace EvaluacionTecnica.Repository
{
    public class BaseRepository<E> : IBaseRepository<E> where E : class
    {
        public EvaluacionTecnicaDbContext _context;

        public BaseRepository(EvaluacionTecnicaDbContext context)
        {
            _context = context;
        }

        public E Add(E entity)
        {
            _context.Set<E>().Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public List<E> AddRange(List<E> entity)
        {
            _context.Set<E>().AddRange(entity);
            _context.SaveChanges();

            return entity;
        }

        public void Delete(int id)
        {
            var entity = this.GetById(id);

            GenericObject.TrySetProperty(entity, "IsActive", false);

            _context.SaveChanges();
        }

        public IQueryable<E> GetAll()
        {
            return _context.Set<E>().AsQueryable();
        }

        public virtual E GetById(int id)
        {
            return _context.Set<E>().Find(id);
        }

        public void Update(E entity)
        {
            _context.Set<E>().AddOrUpdate(entity);
            _context.SaveChanges();
        }

        public void UpdateRamge(List<E> entities)
        {
            throw new NotImplementedException();
        }
    }
}