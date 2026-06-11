namespace MovieTutorial.Common.Pages;

[Route("Dashboard/[action]")]
public class DashboardPage : Controller
{
    [PageAuthorize, HttpGet, Route("~/")]
    public ActionResult Index([FromServices] ISqlConnections sqlConnections)
    {
        var model = new DashboardPageModel();
        using var connection = sqlConnections.NewByKey("Default");
        model.MovieCount = connection.Count<MovieDB.MovieRow>();
        model.GenreCount = connection.Count<MovieDB.GenreRow>();
        model.PersonCount = connection.Count<MovieDB.PersonRow>();
        return View(MVC.Views.Common.Dashboard.DashboardIndex, model);
    }
}