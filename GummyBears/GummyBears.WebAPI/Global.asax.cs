using Autofac;
using Autofac.Core;
using Autofac.Integration.WebApi;
using AutoMapper;
using GummyBears.DAL;
using GummyBears.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace GummyBears.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            
            IContainer container = AutofacContainerBuilder.BuildContainer();
        }
    }

    public static class AutofacContainerBuilder
    {
        public static IContainer BuildContainer()
        {
            var config = GlobalConfiguration.Configuration;
            var builder = new ContainerBuilder();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            //builder.RegisterType<Service>();

            builder.RegisterType<GummyBearsContext>().As<DbContext>();
            builder.RegisterAssemblyTypes(assemblies)
                   .Where(t => t.Name.EndsWith("Repository", StringComparison.Ordinal))
                   .AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(assemblies)
                   .Where(t => t.Name.EndsWith("Service", StringComparison.Ordinal))
                   .AsImplementedInterfaces();

            // Automapper
            builder.RegisterAssemblyTypes().AssignableTo(typeof(Profile));
            builder.Register(c => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            })).AsSelf().SingleInstance();
            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();
            
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).InstancePerRequest();
            builder.RegisterWebApiFilterProvider(config);

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            return container;
        }
    }
}
