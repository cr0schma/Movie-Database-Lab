using MovieDatabase;
using System.Reflection;
using System.Linq;

string title;
string category;

List<Movies> movies = new()
{
    new Movies(title = "Scream", category = "horror" ),
    new Movies(title = "The Ring", category = "horror"),
    new Movies(title = "Saw", category = "horror"),
    new Movies(title = "The Lion King", category = "animated"),
    new Movies(title = "Shrek", category = "animated"),
    new Movies(title = "Cars", category = "animated"),
    new Movies(title = "Gladiator", category = "drama"),
    new Movies(title = "Good Will Hunting", category = "drama"),
    new Movies(title = "The Dark Knight", category = "drama"),
    new Movies(title = "Guardians of the Galaxy", category = "scifi")

};

Console.WriteLine("Welcome to the Movie List Application!\n");
Console.WriteLine($"There are {movies.Count} movies in this list.");

bool playagain = true;
while (playagain)
{
    Console.Write("What category are you interested in?: ");
    string userCategory = Console.ReadLine();

    var userMovies = movies.Where(x => x.movieCategory == userCategory);

    if (userMovies.Count() > 0)
    {
        foreach (var movie in userMovies)
        {
            Console.WriteLine(movie.movieTitle);
        }
    }
    else
    {
        Console.WriteLine("That is an invalid category");
    }

    Console.Write("Continue ? (y/n): ");
    string userDecision = Console.ReadLine();

    if (userDecision == "n")
    {
        playagain = false;
    }
}