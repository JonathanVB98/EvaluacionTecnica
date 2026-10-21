using AutoMapper;
using EvaluacionTecnica.Models;
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
            #endregion

            #region Manager
            #endregion
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}