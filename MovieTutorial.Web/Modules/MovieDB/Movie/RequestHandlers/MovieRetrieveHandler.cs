using Serenity.Services;
using MyRow = MovieTutorial.MovieDB.MovieRow;
using MyResponse = Serenity.Services.RetrieveResponse<MovieTutorial.MovieDB.MovieRow>;
using MyRequest = Serenity.Services.RetrieveRequest;

namespace MovieTutorial.MovieDB;

public interface IMovieRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class MovieRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieRetrieveHandler
{
    public MovieRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}