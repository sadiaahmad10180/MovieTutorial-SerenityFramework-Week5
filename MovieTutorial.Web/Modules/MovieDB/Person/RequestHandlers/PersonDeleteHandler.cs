using MyRow = MovieTutorial.MovieDB.PersonRow;

namespace MovieTutorial.MovieDB;

public interface IPersonDeleteHandler : IDeleteHandler<MyRow, DeleteRequest, DeleteResponse> { }

public class PersonDeleteHandler(IRequestContext context) :
    DeleteRequestHandler<MyRow, DeleteRequest, DeleteResponse>(context),
    IPersonDeleteHandler
{
}