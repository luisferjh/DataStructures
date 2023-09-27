using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class Client
    {
        public int Id { get; set; }     
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        public Ticket Ticket { get; set; }

    }
}
