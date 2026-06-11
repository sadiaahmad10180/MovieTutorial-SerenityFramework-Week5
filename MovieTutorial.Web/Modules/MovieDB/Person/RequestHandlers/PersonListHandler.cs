using MyRow = MovieTutorial.MovieDB.PersonRow;

namespace MovieTutorial.MovieDB;

public interface IPersonListHandler : IListHandler<MyRow, ListRequest, ListResponse<MyRow>> { }

public class PersonListHandler(IRequestContext context) :
    ListRequestHandler<MyRow, ListRequest, ListResponse<MyRow>>(context),
    IPersonListHandler
{
}