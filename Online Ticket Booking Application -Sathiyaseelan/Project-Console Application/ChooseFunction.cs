using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Console_Application
{
    public enum Functionalities
    {
        AddMovies=1,
        DeleteMovies,
        BookMovies,payment,cancelPayment
    }
    class ChooseFunction
    {
        FunctionManager function = new FunctionManager();
        BookTicket bookTicket = new BookTicket();
        MovieModule movieModule = new MovieModule();
        
        public void FunctionToDo()
        {
            while (true)
            {
                Console.WriteLine("Choose any number you want to work\n1=>AddMovies\n2=>DeleteMovies\n3=>BookMovies\n");/*\n4=>Payment\n5=>CancelPayment");*/
                int.TryParse(Console.ReadLine(), out int number);

                switch ((Functionalities)number)
                {
                    case Functionalities.AddMovies:
                        function.AddMovies();
                        break;
                    case Functionalities.DeleteMovies:
                        function.DeleteMovies();
                        break;
                    case Functionalities.BookMovies:
                        movieModule.ViewMovieDetails();
                        break;
                    default:
                        Console.WriteLine("Enter a valid one!!!");
                        break;
                    //case Functionalities.payment:
                    //    break;
                    //case Functionalities.cancelPayment:
                    //    break;
                }
                Console.WriteLine("Do you want to continue 1=>yes   2=>no");
                int.TryParse(Console.ReadLine(),out int input);
                if (input.Equals((int)Choice.yes))
                    continue;
                else if (input.Equals((int)Choice.no))
                {
                    Console.WriteLine("Your operations successfully executed");
                    break;
                }
               
            }
        }
    }
}
