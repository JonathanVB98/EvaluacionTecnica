using System;
using System.Web.Http;
using EvaluacionTecnica.Manager.IManager;
using EvaluacionTecnica.Models;
using EvaluacionTecnica.Models.Dto;
using EvaluacionTecnica.Utils;
using EvaluacionTecnica.Helpers;
namespace EvaluacionTecnica.Controllers
{
    public class BaseController<VM, E, F> : ApiController where VM : class where E : class where F : class
    {
        private readonly IBaseManager<VM, E> _manager;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseController{VM, E, F}"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public BaseController(IBaseManager<VM, E> manager)
        {
            _manager = manager;
        }

        /// <summary>
        /// Adds the specified view model.
        /// </summary>
        /// <param name="viewModel">The view model.</param>
        /// <returns></returns>
        [System.Web.Http.HttpPost]
        public virtual IHttpActionResult Add(VM viewModel)
        {
            var result = new GenericResponse();

            try
            {
                var model = _manager.Add(viewModel);

                result.Message = "El registro se creó exitosamente!";
            }
            catch (GenericErrorException ex)
            {
                return Content(ex.StatusCode, new GenericResponse
                {
                    Error = true,
                    Message = ex.Message,
                    Data = new GenericErrorResponse
                    {
                        ErrorType = ex.GenericError.IdErrorMessageCatalog,
                        ErrorName = ex.GenericError.ErrorName,
                        ErrorMessage = ex.GenericError.Description,
                    }
                });
            }
            catch (Exception ex)
            {
                return Content(System.Net.HttpStatusCode.InternalServerError, new GenericResponse
                {
                    Error = true,
                    Message = ex.Message,
                    Data = new GenericErrorResponse
                    {
                        ErrorMessage = $"Message: {ex.Message}, InnerException: {ex.InnerException?.Message}",
                    }
                });
            }

            return Ok(result);
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [System.Web.Http.HttpDelete]
        public virtual IHttpActionResult Delete(int id)
        {
            var result = new GenericResponse();

            try
            {
                _manager.Delete(id);

                result.Message = "El registro fue eliminado!";
            }
            catch (GenericErrorException ex)
            {
                return Content(ex.StatusCode, new GenericResponse
                {
                    Error = true,
                    Message = ex.Message,
                    Data = new GenericErrorResponse
                    {
                        ErrorType = ex.GenericError.IdErrorMessageCatalog,
                        ErrorName = ex.GenericError.ErrorName,
                        ErrorMessage = ex.GenericError.Description,
                    }
                });
            }
            catch (Exception ex)
            {
                return Content(System.Net.HttpStatusCode.InternalServerError, new GenericResponse
                {
                    Error = true,
                    Message = ex.Message,
                    Data = new GenericErrorResponse
                    {
                        ErrorMessage = $"Message: {ex.Message}, InnerException: {ex.InnerException?.Message}",
                    }
                });
            }

            return Ok(result);
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <param name="pagingParameter">The paging parameter.</param>
        /// <param name="entityFilter">The entity filter.</param>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        public virtual IHttpActionResult GetAll(QueryParameter pagingParameter, F entityFilter)
        {
            var result = new GenericResponse();

            try
            {
                result.Data = new { Models = _manager.GetAll(pagingParameter, (Filters.IFilter)entityFilter) };
            }
            catch (GenericErrorException ex)
            {
                return Content(ex.StatusCode, new GenericResponse
                {
                    Error = true,
                    Message = ex.Message,
                    Data = new GenericErrorResponse
                    {
                        ErrorType = ex.GenericError.IdErrorMessageCatalog,
                        ErrorName = ex.GenericError.ErrorName,
                        ErrorMessage = ex.GenericError.Description,
                    }
                });
            }
            catch (Exception ex)
            {
                return Content(System.Net.HttpStatusCode.InternalServerError, new GenericResponse
                {
                    Error = true,
                    Message = ex.Message,
                    Data = new GenericErrorResponse
                    {
                        ErrorMessage = $"Message: {ex.Message}, InnerException: {ex.InnerException?.Message}",
                    }
                });
            }

            return Ok(result);
        }

        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        public virtual IHttpActionResult GetById(int id)
        {
            var result = new GenericResponse();

            try
            {
                result.Data = new { Model = _manager.GetById(id) };
            }
            catch (GenericErrorException ex)
            {
                return Content(ex.StatusCode, new GenericResponse
                {
                    Error = true,
                    Message = ex.Message,
                    Data = new GenericErrorResponse
                    {
                        ErrorType = ex.GenericError.IdErrorMessageCatalog,
                        ErrorName = ex.GenericError.ErrorName,
                        ErrorMessage = ex.GenericError.Description,
                    }
                });
            }
            catch (Exception ex)
            {
                return Content(System.Net.HttpStatusCode.InternalServerError, new GenericResponse
                {
                    Error = true,
                    Message = ex.Message,
                    Data = new GenericErrorResponse
                    {
                        ErrorMessage = $"Message: {ex.Message}, InnerException: {ex.InnerException?.Message}",
                    }
                });
            }

            return Ok(result);
        }

        /// <summary>
        /// Updates the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="viewModel">The view model.</param>
        /// <returns></returns>
        [System.Web.Http.HttpPatch]
        public virtual IHttpActionResult Update(int id, VM viewModel)
        {
            var result = new GenericResponse();

            try
            {
                _manager.Update(id, viewModel);

                result.Message = "El registro fue actualizado!";
            }
            catch (GenericErrorException ex)
            {
                return Content(ex.StatusCode, new GenericResponse
                {
                    Error = true,
                    Message = ex.Message,
                    Data = new GenericErrorResponse
                    {
                        ErrorType = ex.GenericError.IdErrorMessageCatalog,
                        ErrorName = ex.GenericError.ErrorName,
                        ErrorMessage = ex.GenericError.Description,
                    }
                });
            }
            catch (Exception ex)
            {
                return Content(System.Net.HttpStatusCode.InternalServerError, new GenericResponse
                {
                    Error = true,
                    Message = ex.Message,
                    Data = new GenericErrorResponse
                    {
                        ErrorMessage = $"Message: {ex.Message}, InnerException: {ex.InnerException?.Message}",
                    }
                });
            }

            return Ok(result);
        }
    }
}