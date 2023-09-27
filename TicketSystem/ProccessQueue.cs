using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class ProccessQueue
    {
        private readonly Queue<Client> _clients;
        //private readonly RepositoryClient _repositoryClient;

        public ProccessQueue()
        {
            //_repositoryClient = new RepositoryClient();
            _clients = new Queue<Client>();
           
        }

        public void DequeuedClient() 
        {
            _clients.Dequeue();
        }

        public Client GetFirstClient()
        {
            return _clients.Peek();
        }

        public void EnqueuedClient(Client client)
        {
            _clients.Enqueue(client);
        }

        public int TotalEnqueued() 
        {
            return _clients.Count;
        }

        public void EnqueueClients(List<Client> clients) 
        {
            clients = clients             
               .OrderBy(ob => ob.RegistrationDate).ToList();

            foreach (var client in clients)
            {
                _clients.Enqueue(client);
            }
        }

        public Queue<Client> GetEnqueueds() 
        {          
            return _clients;
        }       

    }
}
