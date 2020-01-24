using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Console_Application
{
    public enum Choice
    {
        
        yes = 1,
        no = 2

    }
    class MovieModule
    {
       internal static List<Movies> listOfMovies = new List<Movies>();
              
        static MovieModule()
        {
            listOfMovies.Add(new Movies {MovieId=1,MovieName="Darbar",ThreatreName="Fun Cinemas", Language="TAMIL", Duration= "2 hrs 40 mins",Address= "Avinashi Rd, Near PSG Krishnammal College, periyar nagar, Coimbatore, Tamil Nadu 641004", TotalSeat = 70 });
            listOfMovies.Add(new Movies {MovieId=2,MovieName = "Pattas", ThreatreName = "INOX: Prozone Mall, Coimbatore", Language = "TAMIL", Duration = "2 hrs 22 mins", Address = "S.F. No. 201, Sathy Main Road, Coimbatore, Tamil Nadu 641035, India", TotalSeat = 70 });
            listOfMovies.Add(new Movies {MovieId=3,MovieName = "Dolittle", ThreatreName = "INOX: Prozone Mall, Coimbatore", Language = "ENGLISH, HINDI, TELUGU, TAMIL", Duration = "1 hrs 41 mins",Address = "S.F. No. 201, Sathy Main Road, Coimbatore, Tamil Nadu 641035, India", TotalSeat = 70 });
        }
        BookTicket bookTicket = new BookTicket();

        public void ViewMovieDetails()
        {
             
            Console.WriteLine("Display all movies running in threates\n");
            foreach(Movies list in listOfMovies)
            {
                Console.WriteLine("MovieId:{0}\nMovieName:{1}\nThreatreName:{2}\nLanguage:{3}\nDuration:{4}\nTotal-Seats Available:{5}\nAddress:{6}\n",list.MovieId,list.MovieName,list.ThreatreName,list.Language,list.Duration,list.TotalSeat,list.Address);
            }
            Console.WriteLine("Do you want to book tickets?\n1=>Yes\n2=No");
            try
            {
                int.TryParse(Console.ReadLine(), out int confirmInput);
                BookTicket book = new BookTicket();
               
                switch ((Choice)confirmInput)
                {
                    case Choice.yes:
                        if (ValidateRoles.userLogedIn >0 || ValidateRoles.adminLogedIn > 0)
                        {
                            book.SelectMoviesAndTickets();
                        }

                        else
                        {
                            UserLoginDetails.AskUserForSignin();
                        }
                        break;
                    case Choice.no:
                        Console.WriteLine("Thanks!! See you again");
                        break;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
          

        }

       
    }
}
