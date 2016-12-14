using System;
using MovieRentalShop.Share.CommandResponses.Movies;
using MovieRentalShop.Share.Commands.Movies;
using MovieRentalShop.Handler.Context;
using AutoMapper;
using System.Linq;
using MovieRentalShop.Handler.Entities;

namespace MovieRentalShop.Handler.Handlers.Movies
{
    public class UpdateMovieHandler : ICommandHandler<UpdateMovieCommand, UpdateMovieCommandResponse>
    {
        private readonly MovieRentalShopContext _dbContext;
        private readonly IMapper _mapper;

        public UpdateMovieHandler(MovieRentalShopContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public UpdateMovieCommandResponse Handle(UpdateMovieCommand command)
        {
            var oldMovie = _dbContext.Movies.FirstOrDefault(x => x.Id == command.Id);
            _mapper.Map<UpdateMovieCommand, Movie>(command, oldMovie);

            _dbContext.SaveChanges();

            return new UpdateMovieCommandResponse();
        }
    }
}
