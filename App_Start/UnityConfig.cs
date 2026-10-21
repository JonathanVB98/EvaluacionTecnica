using AutoMapper;
using EvaluacionTecnica.Manager;
using EvaluacionTecnica.Manager.IManager;
using EvaluacionTecnica.Models;
using EvaluacionTecnica.Repository;
using EvaluacionTecnica.Repository.IRepository;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace EvaluacionTecnica.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());

            container.RegisterFactory<IMapper>(c => mapperConfig.CreateMapper());

            #region Repository
            container.RegisterType<IRolRepository, RolRepository>();
            container.RegisterType<IEmpleadoRepository, EmpleadoRepository>();

            #endregion

            #region Manager
            container.RegisterType<IRolManager, RolManager>();
            container.RegisterType<IEmpleadoManager, EmpleadoManager>();
            #endregion

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}