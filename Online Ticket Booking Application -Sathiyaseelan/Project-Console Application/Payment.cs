using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Console_Application
{
    public enum Seat
    {
        Silver = 1,
        Gold,
        Platinum
    }
    class Payment
    {
         decimal typeCost;
        static internal decimal price;
        decimal discountRate=40;
       

        public void CalculateCost()
        {
            
            if (BookTicket.seatType.Equals((int)Seat.Gold))
            {
                typeCost += 180;
            }
            else if (BookTicket.seatType.Equals((int)Seat.Platinum))
            {
                typeCost += 200;
            }
            else
            {
                typeCost += 120;
            }

            price += typeCost * (Ticket.TicketCount);
            //Console.WriteLine("Price:{0}",price);
           
           
           
            Console.WriteLine();
           
          
             FurtherBooking furtherBooking = new FurtherBooking();
        furtherBooking.BookAnotherOption();
            ApplyDiscount();
            
               

         


        }

        public  void DisplayBookedMovieDetails()
        {

            Console.WriteLine("Dispalying Your Movie Details\n");
            foreach (var items in SelectedMoviesList.bookedMovies)
            {
                Console.WriteLine("\nMovie name:{0}\nThreatre name:{1}\nAddress:{2}\nSeatType:{3}\nShowTime:{4}", items.MovieName, items.ThreatreName, items.Address, items.SeatType, items.ShowTime);
            }
        }
        //Discounts for admin person
        public void ApplyDiscount()
        {
            if (ValidateRoles.adminLogedIn == 1)
            {
                decimal discount = price * (discountRate / 100);
                price += price - discount;
                Console.WriteLine("Total Prize:{0}\n",price);
            }
        }
    }
}
