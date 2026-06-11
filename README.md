# Movie Tutorial by Sadia Ahmad
 
**Submission:** Serenity Framework  


## Description

A fully working Movie Information System built by following the official [Serenity Framework Movies Tutorial](https://serenity.is/docs/tutorials/movies/00-introduction).

The application demonstrates the four core understanding areas required by the assignment:

* **Entity Generation**: Database tables created via FluentMigrator migrations, code generated using `dotnet sergen`
* **UI Pages**: Grid and dialog pages for Movies, Genres, and Persons with full CRUD functionality
* **Permissions**: Role-based access control using `Administration:General` permission key
* **Data Binding**: Lookup editors, many-to-many genre selection, master-detail cast grid


## Technology Stack

|Component|Technology|
|-|-|
|Framework|Serenity Framework 9.1.1|
|Backend|ASP.NET Core / .NET 8|
|Frontend|TypeScript, Bootstrap 5|
|Database|SQL Server LocalDB|
|ORM|Dapper + FluentMigrator|
|IDE|Visual Studio 2026 Community|


## Features Implemented

* Movies grid with search, filtering by genre, pagination
* Movie dialog with Title, Description, Storyline, Year, Release Date, Runtime, Kind (Film/TV Series/Mini Series)
* Multiple genre selection per movie (many-to-many)
* Cast management per movie (master-detail grid with Actor and Character)
* Genre management page (CRUD)
* Person management page with birth date, birth place, gender, height
* Dashboard showing live counts of Movies, Genres, and Persons
* Demo modules (Northwind, BasicSamples, AdvancedSamples) removed for clean deployment


## Screenshots

### Login Page

!\[Login Page]([screenshots/login.png](https://github.com/sadiaahmad10180/MovieTutorial-SerenityFramework-Week5/blob/master/screenshots/login.png))

### Dashboard

!\[Dashboard]([screenshots/dashboard.png](https://github.com/sadiaahmad10180/MovieTutorial-SerenityFramework-Week5/blob/master/screenshots/dashboard.png))

### Movies Grid

!\[Movies Grid]([screenshots/movies\_grid.png](https://github.com/sadiaahmad10180/MovieTutorial-SerenityFramework-Week5/blob/master/screenshots/movies_grid.png))

### Movie Dialog (New Movie)

!\[Movie Dialog](https://github.com/sadiaahmad10180/MovieTutorial-SerenityFramework-Week5/blob/master/screenshots/movies_grid.png)

### Genre Management

!\[Genres]([screenshots/genres.png](https://github.com/sadiaahmad10180/MovieTutorial-SerenityFramework-Week5/blob/master/screenshots/genres.png))

### Person Management

!\[Persons]([screenshots/persons.png](https://github.com/sadiaahmad10180/MovieTutorial-SerenityFramework-Week5/blob/master/screenshots/persons.png))


## How to Run

1. Clone the repository
2. Open `MovieTutorial.sln` in Visual Studio 2022+
3. Make sure SQL Server LocalDB is installed
4. Press **Ctrl F5** migrations run automatically on startup
5. Login with: **Username:** `admin` | **Password:** `serenity`


## Database Tables

|Table|Description|
|-|-|
|Movie|Core movie information|
|Genre|Movie genres|
|MovieGenres|Many-to-many link between Movies and Genres|
|Person|Actors and other persons|
|MovieCast|Cast list per movie (links Movie and Person)|



