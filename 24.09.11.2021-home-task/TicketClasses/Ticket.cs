using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._09._11._2021_home_task.TicketClasses
{
    class Ticket
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public DateTime Date { get; set; }
        public DateTime SellDate { get; set; }
        public TimeSpan Time { get; set; }
        public double Price { get; set; }
    }
}
