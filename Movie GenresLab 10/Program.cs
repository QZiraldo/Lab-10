using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_GenresLab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string title, category;
            List<Movie> MovieList = new List<Movie>();
            

            MovieList.Add(new Movie("The Shawshank Redemption", "Drama"));
            MovieList.Add(new Movie("Inside Man", "Drama"));
            MovieList.Add(new Movie("Stranger Than Fiction", "Comedy"));
            MovieList.Add(new Movie("Along Came Polly", "Comedy"));
            MovieList.Add(new Movie("Miracle", "Sports"));
            MovieList.Add(new Movie("The Natural", "Sports"));
            MovieList.Add(new Movie("Dodgeball: an Underdog Story", "Sports"));
            MovieList.Add(new Movie("The Incredibles", "Animated"));
            MovieList.Add(new Movie("The Lion King", "Animated"));
            MovieList.Add(new Movie("A Goofy Movie", "Animated"));

            foreach (Movie N in MovieList)
            {
                Console.WriteLine(N.getTitle());
                
            }
        }

    }
}
