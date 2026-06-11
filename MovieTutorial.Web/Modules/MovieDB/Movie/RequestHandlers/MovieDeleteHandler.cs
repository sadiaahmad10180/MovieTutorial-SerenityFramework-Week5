using Serenity.Services;
using MyRow = MovieTutorial.MovieDB.MovieRow;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRequest = Serenity.Services.DeleteRequest;
namespace MovieTutorial.MovieDB;

public interface IMovieDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class MovieDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMovieDeleteHandler
{
    public IServiceResolver<IMovieCastDeleteHandler> movieCastDelete;

    public MovieDeleteHandler(IRequestContext context, IServiceResolver<IMovieCastDeleteHandler> movieCastDelete)
        : base(context)
    {
        
    }

    
}