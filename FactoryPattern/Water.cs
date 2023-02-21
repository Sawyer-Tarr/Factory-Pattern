using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Water : IOrderable
    {
        public double Price { get; set; } = 0.00;

        public void Menu()
        {
            Console.WriteLine("I'm sorry, we don't serve that here, here is a complementary water while you think of a new choice.");
        }
    }
}
