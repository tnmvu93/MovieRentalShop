using Autofac;
using AutoMapper;

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
            Mapper.AddProfile<MappingFromEntityProfile>();
        }
    }
}
