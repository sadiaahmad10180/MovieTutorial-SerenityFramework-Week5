using MyRow = MovieTutorial.Administration.RoleRow;

namespace MovieTutorial.Administration;

public interface IRoleDeleteHandler : IDeleteHandler<MyRow> { }

public class RoleDeleteHandler(IRequestContext context)
    : DeleteRequestHandler<MyRow>(context), IRoleDeleteHandler
{
}