using System.Web.Http;

namespace MovieRentalShop.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            IocContainer.SetUp();
        }
    }
}
