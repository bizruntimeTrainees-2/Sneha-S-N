using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Newtonsoft.Json;
namespace SerializationAndDeserialization
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Serialization");
            Movie movie = new Movie { Id = 1, Title = "Mission Impossible" };
            string result = JsonConvert.SerializeObject(movie);
            Console.WriteLine(result);

            Console.WriteLine("\nDesirialisation");
            Movie newMovie = JsonConvert.DesirializeObject<movie>(result);
            Console.WriteLine("Id is : " newMovie.Id);
            Console.WriteLine("Title is : " newMovie.Title);

            Console.WriteLine("\n Serialization of Collection");
            List<Movie> movies = new List<Movie>
            {
                new Movie{ Id = 1, Title = "Titanic" },
                new Movie{ Id = 2, Title = "The martain"},
                new Movie{ Id = 3, Title = "Black Panther"},
                new Movie{ Id = 4, Title = "DeadPool2"},
            };

            string collectionResult = JsonConvert.SerializeObject(movies);
            Console.WriteLine(collectionResult);

            Console,WriteLine("\n Deserialization of Collection");
            List<Movie> newMovies = Json.DesirializeObject<List<Movie>>(collectionResult);
            foreach (var item in newMovies)
            {
                Console.WriteLine("Id : " + item.Id + "\t Title : " +item.Title);
            }
        }
    }
        class Movie
        {
            public int Id
            {
                get ; set ;
            }
            public string Title
            {
                get ; set ; 
            }
        }
    }
}
