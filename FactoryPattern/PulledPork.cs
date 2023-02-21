﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class PulledPork : IOrderable
    {
        public double Price { get; set; } = 6.00;

        public void Menu()
        {
            Console.WriteLine("Thank you for ordering a Pulled Pork sandwich. It will be ready in a moment.");
        }
    }
}
