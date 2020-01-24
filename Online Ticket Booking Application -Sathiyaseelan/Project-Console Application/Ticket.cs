using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Console_Application
{
    class Ticket
    {
        public static int Id { get; set; }
        public static int TicketCount { get; set; }
        public int SeatType { get; set; }
        public int ShowTime { get; set; }
        public Ticket(int id,int ticCount,int seat,int showTime)
        {
            Id = id;
            TicketCount = ticCount;
            this.SeatType = seat;
            this.ShowTime = showTime;
        }
    }
}
