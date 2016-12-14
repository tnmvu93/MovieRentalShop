using System;
using MovieRentalShop.Share.CommandResponses.Movies;
using MovieRentalShop.Share.Commands.Movies;

namespace MovieRentalShop.Handler.Handlers.Movies
{
    public class UpdateMovieCommandHandler : ICommandHandler<UpdateMovieCommand, UpdateMovieCommandResponse>
    {
        public UpdateMovieCommandResponse Handle(UpdateMovieCommand query)
        {
            throw new NotImplementedException();
        }
    }
}
