using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Console_Application
{
   
    public enum showTiming
    {
        Morning=1,
        Evening=2,
        Night=3
    }
    class BookTicket
    {
        public static int seatType;
        public static int showTime;
        public static int id;
        public static List<Ticket> tickets = new List<Ticket>();
        public void SelectMoviesAndTickets()
        {
            Console.WriteLine("Enter movie id to select movie");
            int.TryParse(Console.ReadLine(),  out id);
            Console.WriteLine("How many tickets you want to book");
            int.TryParse(Console.ReadLine(), out int ticketCount);
            Console.WriteLine("Select type\n1=>Silver\n2=>Gold\n3=>Platinum");
            int.TryParse(Console.ReadLine(), out seatType);
            Console.WriteLine("Select time\n1=>Morning-Show\n2=Evening-Show\n3=>Night-Show");
            int.TryParse(Console.ReadLine(), out showTime);
            tickets.Add(new Ticket(id,ticketCount, seatType, showTime));
            Payment pay = new Payment();

            //var selectedList= MovieModule.listOfMovies.Find(x=>x.MovieId.Equals(id));
            //SelectedMoviesList.bookedMovies.Add(new BookedMovies(selectedList.MovieName,selectedList.ThreatreName,selectedList.Address,seatType,showTime));
            pay.CalculateCost();

        }
    }
}
