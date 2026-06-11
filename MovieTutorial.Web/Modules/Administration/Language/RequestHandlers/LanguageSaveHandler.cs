using MyRow = MovieTutorial.Administration.LanguageRow;

namespace MovieTutorial.Administration;

public interface ILanguageSaveHandler : ISaveHandler<MyRow> { }

public class LanguageSaveHandler(IRequestContext context)
    : SaveRequestHandler<MyRow>(context), ILanguageSaveHandler
{
}