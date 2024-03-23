// See https://aka.ms/new-console-template for more information

using Cw03.Containers;

namespace Cw03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var liquidContainer = new LiquidContainer(10, 15, 20, 100);
            var liquidContainer2 = new LiquidContainer(10, 15, 20, 100);

            Console.WriteLine(liquidContainer.SerialNumber);
            Console.WriteLine(liquidContainer2.SerialNumber);
        }
    }
}