using MyRow = MovieTutorial.MovieDB.GenreRow;

namespace MovieTutorial.MovieDB;

public interface IGenreRetrieveHandler : IRetrieveHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>> { }

public class GenreRetrieveHandler(IRequestContext context) :
    RetrieveRequestHandler<MyRow, RetrieveRequest, RetrieveResponse<MyRow>>(context),
    IGenreRetrieveHandler
{
}