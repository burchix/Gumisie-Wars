using Autofac;
using Autofac.Integration.Wcf;
using AutoMapper;
using GummyBears.DAL;
using GummyBears.DAL.Mapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web;

namespace GummyBears.Service
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            IContainer container = AutofacContainerBuilder.BuildContainer();
            AutofacHostFactory.Container = container;
        }
    }

    public static class AutofacContainerBuilder
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            builder.RegisterType<Service>();

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