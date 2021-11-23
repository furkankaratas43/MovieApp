using System.Linq;

namespace MovieApp.Models
{
    public static class Repository
    {
        private static List<Movie> _movies = null;

        static Repository() => _movies = new List<Movie>(){
                new Movie() { Id = 1, Name = "The Ides Of March", Description = "The Ides Of March", ImageUrl = "1.jpg"},
                new Movie() { Id = 2, Name = "Devil", Description = "Devil", ImageUrl = "2.jpg"},
                new Movie() { Id = 3, Name = "Zero Dark Thirty", Description = "Zero Dark Thirty", ImageUrl = "3.jpg"},
                new Movie() { Id = 4, Name = "The Rum Diary", Description = "The Rum Diary", ImageUrl = "4.jpg"},
                new Movie() { Id = 5, Name = "Us", Description = "Us", ImageUrl = "5.jpg"}
            };

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }

    }
}