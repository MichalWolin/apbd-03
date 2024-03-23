// See https://aka.ms/new-console-template for more information

using Cw03.Containers;
using Cw03.Enums;

namespace Cw03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var liquidContainer = new LiquidContainer(250, 1000, 150, 10_000);
            var gasContainer = new GasContainer(250, 1000, 150, 10_000);
            var coolingContainer = new CoolingContainer(250, 1_001, 150,
                10_000, PossibleProducts.Chocolate);

            liquidContainer.Load(5_001, true);
            liquidContainer.Load(9_001, false);
            liquidContainer.Load(5_000, true);
            Console.WriteLine(liquidContainer);

            gasContainer.Load(10_000);
            Console.WriteLine(gasContainer);
            gasContainer.Unload();
            Console.WriteLine(gasContainer);
            gasContainer.NotifyAboutHazard();

            ContainerShip containerShip = new ContainerShip("Ever Given", 40,
                1_000, 1_000_000);
            ContainerShip containerShip2 = new ContainerShip("Dar Młodzieży", 70,
                1, 1_000);

            containerShip.LoadContainer(liquidContainer);
            containerShip.UnloadContainer(liquidContainer);
            containerShip.LoadContainers([liquidContainer, gasContainer]);
            containerShip.ReplaceContainer(liquidContainer, coolingContainer);
            containerShip.MoveContainer(coolingContainer, containerShip2);
            Console.WriteLine(containerShip);
            Console.WriteLine(containerShip2);
        }
    }
}