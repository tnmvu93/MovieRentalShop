using Autofac;
using AutoMapper;

namespace MovieRentalShop.Handler.Mapping
{
    public class MappingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<MappingFromEntityProfile>();
                x.AddProfile<MappingToEntityProfile>();
            });

            builder.Register(x => Mapper.Instance).As<IMapper>();
        }
    }
}
