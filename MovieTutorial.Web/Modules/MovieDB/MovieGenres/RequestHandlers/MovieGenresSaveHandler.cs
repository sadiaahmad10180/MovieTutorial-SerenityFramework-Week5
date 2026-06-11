using MyRow = MovieTutorial.MovieDB.MovieGenresRow;

namespace MovieTutorial.MovieDB;

public interface IMovieGenresSaveHandler : ISaveHandler<MyRow, SaveRequest<MyRow>, SaveResponse> { }

public class MovieGenresSaveHandler(IRequestContext context) :
    SaveRequestHandler<MyRow, SaveRequest<MyRow>, SaveResponse>(context),
    IMovieGenresSaveHandler
{
}