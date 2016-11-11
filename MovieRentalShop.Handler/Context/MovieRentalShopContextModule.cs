using Autofac;

namespace MovieRentalShop.Handler.Context
{
    public class MovieRentalShopContextModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MovieRentalShopContext>().AsSelf().InstancePerRequest();
        }
    }
}
