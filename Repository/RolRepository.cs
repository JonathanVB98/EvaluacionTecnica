using EvaluacionTecnica.Models;
using EvaluacionTecnica.Models.Dto;
using EvaluacionTecnica.Models.Tables;
using EvaluacionTecnica.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionTecnica.Repository
{
    public class RolRepository : BaseRepository<Rol>, IRolRepository
    {
        protected readonly EvaluacionTecnicaDbContext context;

        public RolRepository(EvaluacionTecnicaDbContext context) : base(context)
        {
            this.context = context;
        }

        public override Rol GetById(int id)
        {
            return _context.Set<Rol>().Where(u => u.RolId == id).FirstOrDefault();
        }

        public List<Rol> GetRol()
        {
           return _context.Set<Rol>().ToList();
        }
    }
}