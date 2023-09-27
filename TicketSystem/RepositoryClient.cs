using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class RepositoryClient
    {
        private readonly DbContextOptions<DbContextTicket> optionsDb;
        public RepositoryClient()
        {
            optionsDb = new DbContextOptionsBuilder<DbContextTicket>()
            .UseInMemoryDatabase(databaseName: "InMemoryDb")
            .Options;
        }
        public void RegisterClient(Client client) 
        {
            using (var context = new DbContextTicket(optionsDb))
            {
                context.Clients.Add(client);
                context.SaveChanges();
            }
        }

        public void RegisterClients(List<Client> clients)
        {
            using (var context = new DbContextTicket(optionsDb))
            {
                context.Clients.AddRange(clients);
                context.SaveChanges();
            }
        }

        public List<Client> GetClients()
        {
            using (var context = new DbContextTicket(optionsDb))
            {
                return context.Clients.ToList();
            }
        }

        public void MockClient()
        {
            if(GetClients().Count <= 0)
            {
                List<Client> clients = new List<Client>()
            {
                new Client
                {
                    Id = 1,
                    Name = "Cliente1",
                    RegistrationDate = DateTime.Now,
                    Ticket = null
                },
                new Client
                {
                    Id = 2,
                    Name = "Cliente2",
                    RegistrationDate = DateTime.Now,
                    Ticket = null
                },
                new Client
                {
                    Id = 3,
                    Name = "Cliente3",
                    RegistrationDate = DateTime.Now,
                    Ticket = null
                },
                new Client
                {
                    Id = 4,
                    Name = "Cliente4",
                    RegistrationDate = DateTime.Now,
                    Ticket = null
                },
                new Client
                {
                    Id = 5,
                    Name = "Cliente5",
                    RegistrationDate = DateTime.Now,
                    Ticket = null
                },
                new Client
                {
                    Id = 6,
                    Name = "Cliente6",
                    RegistrationDate = DateTime.Now,
                    Ticket = null
                }
            };

                RegisterClients(clients);
            }

           
        }

    }
}
