using Autofac;
using Autofac.Core;
using Autofac.Integration.WebApi;
using AutoMapper;
using GummyBears.BLL.Interfaces;
using GummyBears.BLL.Logging;
using GummyBears.DAL;
using GummyBears.DAL.Mapper;
using GummyBears.WebAPI.Filters;
using Microsoft.Owin;
using Owin;
using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web.Compilation;
using System.Web.Http;

[assembly: OwinStartup(typeof(GummyBears.WebAPI.Startup))]

namespace GummyBears.WebAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var config = GlobalConfiguration.Configuration;
            var builder = new ContainerBuilder();
            var assemblies = BuildManager.GetReferencedAssemblies().Cast<Assembly>().ToArray(); //AppDomain.CurrentDomain.GetAssemblies();
            
            config.Filters.Add(new ExceptionFilter());

            //WebApiConfig.Register(config);

            //builder.RegisterType<Service>();

            //Logger
            builder.RegisterType<Logger>().As<ILogger>().SingleInstance();

            builder.RegisterType<GummyBearsContext>().As<DbContext>().InstancePerRequest();
            builder.RegisterAssemblyTypes(assemblies)
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterAssemblyTypes(assemblies)
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces().InstancePerRequest();

            // Automapper
            builder.RegisterAssemblyTypes().AssignableTo(typeof(Profile));
            builder.Register(c => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            })).AsSelf().SingleInstance();
            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).InstancePerRequest();
            //builder.RegisterWebApiFilterProvider(config);

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            
            //app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
            app.UseWebApi(config);
        }
    }
}
