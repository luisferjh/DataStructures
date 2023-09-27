using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public void ProccessOrder() 
        {
            Console.WriteLine($"Making order {Id}--{Description}");
        }
    }
}
