using MyRow = MovieTutorial.MovieDB.MovieGenresRow;

namespace MovieTutorial.MovieDB;

public interface IMovieGenresRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class MovieGenresRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IMovieGenresRetrieveHandler
{
}