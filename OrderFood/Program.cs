namespace OrderFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order { Id = 1, Description = "Pizza" };
            Order order2 = new Order { Id = 2, Description = "Burger" };
            Order order3 = new Order { Id = 3, Description = "Sushi" };
            Order order4 = new Order { Id = 4, Description = "Salad" };

            QueueOrders queueOrders = new QueueOrders();

            queueOrders.EnqueueOrder(order1);
            queueOrders.EnqueueOrder(order2);
            queueOrders.EnqueueOrder(order3);
            queueOrders.EnqueueOrder(order4);

            queueOrders.MakeOrders();
        }
    }
}