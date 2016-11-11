using Autofac;
using Autofac.Integration.WebApi;
using MovieRentalShop.Api.Dispatchers;
using System.Reflection;
using System.Web.Http;

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

        private static void RegisterDispatchers(ContainerBuilder builder)
        {
            builder.RegisterType<QueryDispatcher>().As<IQueryDispatcher>().InstancePerRequest();
        }
    }
}