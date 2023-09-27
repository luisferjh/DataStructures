using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class Ticket
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public string Number { get; set; }
        public int Room { get; set; }
        public int ChairNumber  { get; set; }
    }
}
