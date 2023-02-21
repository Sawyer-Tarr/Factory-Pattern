using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class BBQTurkey : IOrderable
    {
        public double Price { get; set; } = 7.00;

        public void Menu()
        {
            Console.WriteLine("Thank you for ordering a BBQ Turkey sandwich. It will be ready in a moment.");
        }
    }
}
