using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood
{
    public class QueueOrders
    {
        private readonly Queue<Order> _orders;
        public QueueOrders()
        {
            _orders = new Queue<Order>();
        }

        public void EnqueueOrder(Order order)
        {
            _orders.Enqueue(order);
        }

        private Order DequeueOrder()
        {
            return _orders.Dequeue();
        }

        public void MakeOrders() 
        {
            while (_orders.Count > 0)
            {
                var order = DequeueOrder();
                order.ProccessOrder();
            }

            if (_orders.Count <= 0)
            {
                Console.WriteLine("There is no orders");
            }
        }
    }
}
