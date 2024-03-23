using Cw03.Interfaces;

namespace Cw03.Containers;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double height, double weight, double depth, double maxCargoWeight)
        : base(height, weight, depth, "G", maxCargoWeight)
    {
    }

    public override void Unload()
    {
        CargoWeight *= 0.95;
    }

    public void NotifyAboutHazard(string message)
    {
        Console.WriteLine("Hazard in gas container: " + SerialNumber);
    }
}