using MyRow = MovieTutorial.MovieDB.GenreRow;

namespace MovieTutorial.MovieDB;

public interface IGenreDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class GenreDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IGenreDeleteHandler
{
}