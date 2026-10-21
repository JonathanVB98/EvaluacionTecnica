using EvaluacionTecnica.Filters;
using EvaluacionTecnica.Manager.IManager;
using EvaluacionTecnica.Models;
using EvaluacionTecnica.Models.Dto;
using EvaluacionTecnica.Models.Tables;
using System;
using System.Collections.Generic;
using System.Web.Http;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPatchAttribute = System.Web.Http.HttpPatchAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace EvaluacionTecnica.Controllers
{
    /// <summary>
    /// Controller to access the country entity
    /// </summary>
    [RoutePrefix("api/empleado")]
    public class EmpleadoController : BaseController<EmpleadoDto, Empleado, EmpleadoFilters>
    {
        public IEmpleadoManager _manager;

        public EmpleadoController(IEmpleadoManager manager) : base(manager)
        {
            _manager = manager;
        }

        [HttpPost]
        [Route("add")]
        public override IHttpActionResult Add([FromBody] EmpleadoDto state) => base.Add(state);

        [HttpDelete]
        [Route("delete")]
        public override IHttpActionResult Delete(int id) => base.Delete(id);

        [HttpPost]
        [Route("all")]
        public IHttpActionResult GetAll(EmpleadoFilter entityFilters) => base.GetAll(entityFilters.PagingParameter, entityFilters.EntityFilter);

        [HttpGet]
        [Route("byId")]
        public override IHttpActionResult GetById(int id) => base.GetById(id);

        [HttpPatch]
        [Route("update")]
        public override IHttpActionResult Update(int id, [FromBody] EmpleadoDto state) => base.Update(id, state);

    }
}