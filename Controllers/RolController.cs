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
    [RoutePrefix("api/rol")]
    public class RolController : BaseController<RolDto, Rol, RolFilters>
    {
        public IRolManager _manager;

        public RolController(IRolManager manager) : base(manager)
        {
            _manager = manager;
        }

        [HttpPost]
        [Route("add")]
        public override IHttpActionResult Add([FromBody] RolDto state) => base.Add(state);

        [HttpDelete]
        [Route("delete")]
        public override IHttpActionResult Delete(int id) => base.Delete(id);

        [HttpPost]
        [Route("all")]
        public IHttpActionResult GetAll(RolFilter entityFilters) => base.GetAll(entityFilters.PagingParameter, entityFilters.EntityFilter);

        [HttpGet]
        [Route("byId")]
        public override IHttpActionResult GetById(int id) => base.GetById(id);

        [HttpPatch]
        [Route("update")]
        public override IHttpActionResult Update(int id, [FromBody] RolDto state) => base.Update(id, state);

        [HttpGet]
        [Route("prueba")]
        public IHttpActionResult GetRol()
        {
            try
            {
                List<RolDto> lstRol = _manager.GetRol();

                return Ok(new GenericResponse
                {
                    Data = lstRol
                });
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}