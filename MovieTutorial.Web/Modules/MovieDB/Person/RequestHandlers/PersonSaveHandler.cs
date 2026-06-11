using MyRow = MovieTutorial.MovieDB.PersonRow;

namespace MovieTutorial.MovieDB;

public interface IPersonSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class PersonSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IPersonSaveHandler
{
}