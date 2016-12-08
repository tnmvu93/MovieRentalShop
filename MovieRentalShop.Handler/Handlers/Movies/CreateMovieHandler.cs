using System;
using MovieRentalShop.Share.CommandResponses.Movies;
using MovieRentalShop.Share.Commands.Movies;
using MovieRentalShop.Handler.Context;
using AutoMapper;
using MovieRentalShop.Handler.Entities;

namespace MovieRentalShop.Handler.Handlers.Movies
{
    public class CreateMovieHandler : ICommandHandler<CreateMovieCommand, CreateMovieCommandResponse>
    {
        private MovieRentalShopContext _dbContext;
        private IMapper _mapper;

        public CreateMovieHandler(MovieRentalShopContext dbContext, IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
        }

        public CreateMovieCommandResponse Handle(CreateMovieCommand command)
        {
            var movie = _mapper.Map<CreateMovieCommand, Movie>(command);

            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();

            return new CreateMovieCommandResponse();
        }
    }
}
