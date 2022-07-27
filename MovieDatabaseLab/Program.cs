//Movie Database

using MovieDatabaseLab;
Movie movieOne = new Movie("Unbroken", "drama", 2012);
Movie movieTwo = new Movie("Pulp Fiction", "scifi", 1992);
Movie movieThree = new Movie("The Godfather", "drama", 1988);
Movie movieFour = new Movie("The Dark Knight", "scifi", 2005);
Movie movieFive = new Movie("Forest Gump", "Drama", 1995);
Movie movieSix = new Movie("How To Train Your Dragon", "animated", 2012);
Movie movieSeven = new Movie("American History X", "drama", 1996);
Movie movieEight = new Movie("Saw II", "horror", 2014);
Movie movieNine = new Movie("Friday The 13th", "horror", 1998);
Movie movieTen = new Movie("Gladiator", "drama", 2002);

List<Movie> movieList = new List<Movie>() { movieOne, movieTwo,
    movieThree, movieFour, movieFive, movieSix, movieSeven,
    movieEight, movieNine, movieTen};

string yOrNo;
bool inputCategory = true;
List<string> outputCategory = new List<string>() { "drama", "scifi", "horror", "animated" };

Console.WriteLine("Welcome to the Movies!");
Console.WriteLine("There are 10 movies in this list.");
do
{
    Console.WriteLine("What category are you interested in? drama, scifi, horror or animated");
    string input = Console.ReadLine();
    
    //var movieCategories = movieList.Select(x => x.Category.Contains("scifi")).ToList();
    
    do
    {
       if (outputCategory.Contains(input))

        foreach (Movie movie in movieList)
        {
            
            if (input == movie.Category)
            {
                //var movieCategories = movieList.Select(x => x.Category).ToList();
                 //   movieCategories.Sort();
                movie.printMovieTitle();
                movie.printMovieYear();
                    Console.WriteLine();
            }
            
        }
        else Console.WriteLine("Please enter a valid category");
        break;
    } while (inputCategory == true);

    //should have put this in a different location, should have readline after invalid category prompt
    Console.WriteLine("Would you like to enter another category? y/n to continue:");
    yOrNo = Console.ReadLine().ToLower();
} while (yOrNo.Equals("y"));










//var movieTitles = movieList.Select(x => x.Title).ToList();
//var movieCategories = movieList.Select(y => y.Category).ToList();
//movieTitles.ForEach(x => Console.WriteLine(x));
//movieCategories.ForEach(y => Console.WriteLine(y));