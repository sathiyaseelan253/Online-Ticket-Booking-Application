using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Console_Application
{
    class FunctionManager
    {
        MovieConstructor construct = new MovieConstructor();
        MovieModule module = new MovieModule();
        Movies movie = new Movies();

        public static int itemCount = MovieModule.listOfMovies.Count;
        public void AddMovies()
        {
            itemCount++;
            construct.GetMovieDetails(itemCount);

        }
        public void DeleteMovies()
        {
            Console.WriteLine("Enter movie id to delete");
            try
            {
                int.TryParse(Console.ReadLine(), out int movieId);
                if (MovieModule.listOfMovies.Exists(li=>li.Equals(movieId)))
                {
                    

                    var item = MovieModule.listOfMovies.Find(li => li.Equals(movieId));

                    MovieModule.listOfMovies.Remove(item);
                }
              else
                Console.WriteLine("Invalid movie id");   
                
               


            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
        public void BookMovies()
        {
            BookTicket bookTicket = new BookTicket();

            module.ViewMovieDetails();
           
            
        }
    }
}
