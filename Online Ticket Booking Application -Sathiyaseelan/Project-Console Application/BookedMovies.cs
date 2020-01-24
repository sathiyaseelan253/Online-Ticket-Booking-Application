using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Console_Application
{
    class BookedMovies
    {
        public string MovieName { get; set; }
        public string ThreatreName { get; set; }
        public string Address { get; set; }
        public string ShowTime { get; set; }
        public string SeatType { get; set; }

        public BookedMovies(string movie,string thName,string address, string seatType,string showTime)
        {
            this.MovieName = movie;
            this.ThreatreName = thName;
            this.Address = address;
            this.SeatType = seatType;
            this.ShowTime = showTime;
            
        }
    }
}
