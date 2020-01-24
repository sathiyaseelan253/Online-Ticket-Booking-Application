using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Console_Application
{
    class Movies
    {

        public string MovieName { get; set; }
        public string ThreatreName { get; set; }
        public string Address { get; set; }

        public string Language { get; set; }

        public string Duration { get; set; }
        public int TotalSeat { get; set; }

        public  int MovieId { get; set; }
        public Movies()
        {

        }
        public Movies(int id,string movieName,string threatre,string address,string language,string duration,int seat)
        {
            this.MovieId = id;
            this.MovieName = movieName;
            this.ThreatreName = threatre;
            this.Address = address;
            this.Language = language;
            this.Duration = duration;
            this.TotalSeat = seat;
            

        }
        
    }
}
