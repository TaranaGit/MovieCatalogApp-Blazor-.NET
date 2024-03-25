using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.Client.Models;
namespace MovieStore.Client.Models;


public static class MovieClient
{
    private static readonly List<Movie> movies = new()
    {
new Movie()
{
Id=1,
Name= "Leap Year",
Genre = "Romantic",
Price =19.99M,
ReleaseDate = new DateTime(1991, 2, 1)

},
new Movie()
{
Id=2,
Name= "Journey to Moon",
Genre = "Science Fiction",
Price =29.99M,
ReleaseDate = new DateTime(2001, 5, 1)

},
new Movie()
{
Id=3,
Name= "Tom & Jerry",
Genre = "Animation",
Price =39.99M,
ReleaseDate = new DateTime(1890, 2, 1)

},
new Movie()
{
Id=4,
Name= "The War",
Genre = "Historical",
Price =49.99M,
ReleaseDate = new DateTime(2005, 2, 1)

}, new Movie()
{
Id=5,
Name= "UP",
Genre = "Motivational",
Price =18.79M,
ReleaseDate = new DateTime(2010, 2, 1)

}
};
    public static Movie[] GetMovies()
    {
        return movies.ToArray();
    }

    public static void AddMovie(Movie movie)
    {
        movies.Add(movie);
        movie.Id = movies.Max(x => x.Id) + 1;
    }

    public static Movie GetMovie(int id)
    {
        return movies.Find(item => item.Id == id) ?? throw new Exception("Could not find movie!!");
    }

    public static void UpdateMovie(Movie updateMovie)
    {
        Movie existingMovie = GetMovie(updateMovie.Id);
        existingMovie.Name = updateMovie.Name;
        existingMovie.Genre = updateMovie.Genre;
        existingMovie.Price = updateMovie.Price;
        existingMovie.ReleaseDate = updateMovie.ReleaseDate;
    }

    public static void DeleteMovie(int id)
    {
        Movie movie = GetMovie(id);
        movies.Remove(movie);

    }

}