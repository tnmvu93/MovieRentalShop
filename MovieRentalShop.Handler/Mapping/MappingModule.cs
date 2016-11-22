using Autofac;
using AutoMapper;
using AutoMapper.Mappers;

namespace MovieRentalShop.Handler.Mapping
{
    public class MappingModule : Module
    {
        /// <summary>
        /// Based on http://stackoverflow.com/questions/35187475/autofac-and-automapper-new-api-configurationstore-is-gone
        /// </summary>
        /// <param name="builder"></param>

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(x => new MapperConfiguration(config =>
            {
                config.AddProfile<MappingFromEntityProfile>();
            }));

            builder.Register(x => x.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>();
        }
    }
}
