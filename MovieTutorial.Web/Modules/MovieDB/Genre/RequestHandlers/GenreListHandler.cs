using MyRow = MovieTutorial.MovieDB.GenreRow;

namespace MovieTutorial.MovieDB;

public interface IGenreListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class GenreListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IGenreListHandler
{
}