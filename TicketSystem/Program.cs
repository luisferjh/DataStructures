using Microsoft.EntityFrameworkCore.Internal;

namespace TicketSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // mock data
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

            RepositoryClient repositoryClient = new RepositoryClient();
            repositoryClient.RegisterClients(clients);

            ProccessQueue proccessQueue = new ProccessQueue();
            proccessQueue.EnqueueClients(clients);

            int totalQueued = proccessQueue.TotalEnqueued();
            for (int i = 0; i < totalQueued; i++)
            {
                Client client = proccessQueue.GetFirstClient();
                Ticket ticket = new Ticket 
                {
                    Id = 1,
                    IdClient = client.Id,
                    Number = $"T00{i}",
                    Room = 101,
                    ChairNumber = 5
                };

                proccessQueue.DequeuedClient();

                Console.WriteLine($"Ticket {ticket.Number} assigned for client {client.Name}");
            }

        }
    }
}