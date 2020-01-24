using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Console_Application
{
    class FurtherBooking
    {
        Payment pay = new Payment();
        public void BookAnotherOption()
        {
            while (true)
            {
                Console.WriteLine("Do you want to book another movie\n1=>yes\n2=>no");
                int input;
                int.TryParse(Console.ReadLine(), out input);
                BookTicket bookTicket = new BookTicket();
                if (((Choice)input) == (Choice.yes))
                {
                    SelectItemToStore();
                    bookTicket.SelectMoviesAndTickets();
                }
                else if (((Choice)input).Equals(Choice.no))
                {
                    SelectItemToStore();
                    pay.DisplayBookedMovieDetails();
                    Console.WriteLine("Total Cost:{0}",Payment.price);
                    
                    Console.WriteLine("Thanks for Booking,Enjoy and Have fun");
                    Console.WriteLine("Thank you !!! ,Have a good day");
                   
                }
                else
                {
                    Console.WriteLine("You entered wrong input,please enter valid one");
                    continue;
                }
                break;
            }
        }
        public static void SelectItemToStore()
        {
            var selectedList = MovieModule.listOfMovies.Find(x => x.MovieId.Equals(BookTicket.id));
            Seat seat = (Seat)BookTicket.seatType;
            
            showTiming time = (showTiming)BookTicket.showTime;

            SelectedMoviesList.bookedMovies.Add(new BookedMovies(selectedList.MovieName, selectedList.ThreatreName, selectedList.Address, seat.ToString(),time.ToString()));
        }
    }
}
