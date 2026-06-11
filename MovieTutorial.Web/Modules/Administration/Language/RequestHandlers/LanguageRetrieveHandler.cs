using MyRow = MovieTutorial.Administration.LanguageRow;

namespace MovieTutorial.Administration;

public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow> { }

public class LanguageRetrieveHandler(IRequestContext context)
    : RetrieveRequestHandler<MyRow>(context), ILanguageRetrieveHandler
{
}