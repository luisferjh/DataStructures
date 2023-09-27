using Xunit;

namespace TicketSystem.Test
{
    public class TicketTest
    {
        private readonly RepositoryClient _repositoryClient;
        private readonly ProccessQueue _proccessQueue;

        public TicketTest()
        {            
            _repositoryClient = new RepositoryClient();
            _proccessQueue = new ProccessQueue();
            _repositoryClient.MockClient();
            _proccessQueue.EnqueueClients(_repositoryClient.GetClients());
        }

        [Fact]
        public void ProccessQueue_GetFirstItem()
        {

            var firstClient = _proccessQueue.GetFirstClient();

            // assert
            Assert.NotNull(firstClient);
        }

        [Fact]
        public void ProccessQueue_GetTotalQueue()
        {
            var totalEnqueued = _proccessQueue.TotalEnqueued();
            Assert.Equal(6, totalEnqueued);
        }
    }
}