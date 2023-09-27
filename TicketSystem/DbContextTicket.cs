using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class DbContextTicket:DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Ticket> Ticket { get; set; }

        public DbContextTicket(DbContextOptions<DbContextTicket> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura tus entidades aquí
        }
    }
}
