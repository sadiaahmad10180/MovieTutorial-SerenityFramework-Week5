using MyRow = MovieTutorial.MovieDB.MovieCastRow;

namespace MovieTutorial.MovieDB;

public interface IMovieCastDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class MovieCastDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IMovieCastDeleteHandler
{
}