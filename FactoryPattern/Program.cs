namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what kind of sandwich would you like today?");
            Console.WriteLine("Sloppy Joe, Pulled Pork, or BBQ Turkey?");

            string cusOrder = Console.ReadLine();
            
            IOrderable order1 = SandwichFactory.GetSandwich(cusOrder);

            order1.Menu();
            Console.WriteLine($"That will be {order1.Price} dollars please.");
        }
    }
}
