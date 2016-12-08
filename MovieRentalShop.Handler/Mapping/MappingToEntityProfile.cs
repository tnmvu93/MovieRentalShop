using System;
using AutoMapper;
using MovieRentalShop.Share.Commands.Movies;
using MovieRentalShop.Handler.Entities;

namespace MovieRentalShop.Handler.Mapping
{
    public class MappingToEntityProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<CreateMovieCommand, Movie>();
        }
    }
}
