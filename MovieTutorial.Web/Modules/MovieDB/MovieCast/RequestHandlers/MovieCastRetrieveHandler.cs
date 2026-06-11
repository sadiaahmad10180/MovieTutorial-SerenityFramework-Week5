using MyRow = MovieTutorial.MovieDB.MovieCastRow;

namespace MovieTutorial.MovieDB;

public interface IMovieCastRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class MovieCastRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IMovieCastRetrieveHandler
{
}