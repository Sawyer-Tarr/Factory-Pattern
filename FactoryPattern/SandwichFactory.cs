using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class SandwichFactory
    {
        public static IOrderable GetSandwich(string order) 
        { 
            switch (order.ToLower()) 
            {
                case "pullpork":
                    return new PulledPork();
                case "bbq turkey":
                    return new BBQTurkey();
                case "sloppy joe":
                    return new SloppyJoe();
                default:
                    return new Water();
            }
        }
    }
}
