using Autofac;
using Autofac.Integration.WebApi;
using MovieRentalShop.Api.Dispatchers;
using System;
using System.Reflection;
using System.Web.Http;
using MovieRentalShop.Handler.Handlers;

namespace MovieRentalShop.Api
{
    public static class IocContainer
    {
        /// <summary>
        /// Based on http://docs.autofac.org/en/latest/integration/webapi.html
        /// </summary>
        public static void SetUp()
        {
            var builder = new ContainerBuilder();

            RegisterApiControllers(builder);
            RegisterDispatchers(builder);
            LoadModule(builder);

            var container = builder.Build();

            // Get your HttpConfiguration (for IIS).
            var config = GlobalConfiguration.Configuration;

            // Set the dependency resolver to be Autofac.
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static void RegisterApiControllers(ContainerBuilder builder) 
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
        }


        /// <summary>
        /// Based on http://docs.autofac.org/en/latest/register/scanning.html?highlight=RegisterAssemblyTypes
        /// </summary>
        /// <param name="builder"></param>
        private static void RegisterDispatchers(ContainerBuilder builder)
        {
            builder.RegisterType<QueryDispatcher>().As<IQueryDispatcher>().InstancePerRequest();

            // When hosting applications in IIS all assemblies are loaded into the AppDomain when the application first starts.
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .AsClosedTypesOf(typeof(IQueryHandler<,>))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
                .AsClosedTypesOf(typeof(ICommandHandler<,>))
                .AsImplementedInterfaces();
        }

        private static void LoadModule(ContainerBuilder builder)
        {
            builder.RegisterAssemblyModules(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}