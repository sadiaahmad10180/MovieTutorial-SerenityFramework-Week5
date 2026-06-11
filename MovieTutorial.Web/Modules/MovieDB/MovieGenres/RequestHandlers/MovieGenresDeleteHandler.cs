using MyRow = MovieTutorial.MovieDB.MovieGenresRow;

namespace MovieTutorial.MovieDB;

public interface IMovieGenresDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class MovieGenresDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IMovieGenresDeleteHandler
{
}