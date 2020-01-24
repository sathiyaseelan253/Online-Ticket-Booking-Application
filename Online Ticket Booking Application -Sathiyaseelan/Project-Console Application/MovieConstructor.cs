using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Console_Application
{
    class MovieConstructor
    {
        public void GetMovieDetails(int count)
        {
            
            Console.WriteLine("Enter Movie name");
            string movieName = Console.ReadLine();
            Console.WriteLine("Enter Threatre name");
            string threatreName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Movie Language");
            string language = Console.ReadLine();
            Console.WriteLine("Enter duration");
            string duration = Console.ReadLine();
            Console.WriteLine("Enter Total of seats ");
            int seats =int.Parse( Console.ReadLine());

            MovieModule.listOfMovies.Add(new Movies(count,movieName, threatreName, address, language, duration, seats));

        }
    }
}
