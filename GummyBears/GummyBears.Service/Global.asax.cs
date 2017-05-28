using Autofac;
using Autofac.Integration.Wcf;
using AutoMapper;
using GummyBears.BLL.Interfaces;
using GummyBears.BLL.Logging;
using GummyBears.DAL;
using GummyBears.DAL.Mapper;
using System;
using System.Data.Entity;
using System.Web;

namespace GummyBears.Service
{
    public class Global : HttpApplication
    {
        private ILogger _logger;
        protected void Application_Start()
        {
            IContainer container = AutofacContainerBuilder.BuildContainer();
            _logger = container.Resolve<ILogger>();
            AutofacHostFactory.Container = container;
        }

        void Application_Error()
        {
            // Get the exception object.
            Exception ex = Server.GetLastError();

            _logger.Write($"{ex.Message}, StackTrace: {ex.StackTrace}", LogLevel.ERROR);
            
            // Clear the error from the server
            Server.ClearError();
        }
    }

    public static class AutofacContainerBuilder
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            builder.RegisterType<Service>();

            //Logger
            builder.RegisterType<Logger>().As<ILogger>().SingleInstance();

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

            return builder.Build();
        }
    }
}