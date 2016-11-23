using AutoMapper;
using MovieRentalShop.Handler.Entities;
using MovieRentalShop.Share.ViewModels.Movies;

namespace MovieRentalShop.Handler.Mapping
{
    /// <summary>
    /// Based on https://github.com/AutoMapper/AutoMapper/wiki/Configuration
    /// Using profile instance
    /// </summary>
    public class MappingFromEntityProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Movie, GetMoviesViewModel>();
        }
    }
}
