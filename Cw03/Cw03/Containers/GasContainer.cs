using Cw03.Interfaces;

namespace Cw03.Containers;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }

    public GasContainer(double height, double weight, double depth, double maxCargoWeight)
        : base(height, weight, depth, "G", maxCargoWeight)
    {
    }

    public override void Unload()
    {
        CargoWeight *= 0.05;
    }

    public void NotifyAboutHazard(string message)
    {
        Console.WriteLine(message);
    }

    public void NotifyAboutHazard()
    {
        NotifyAboutHazard("Hazard in gas container: " + SerialNumber);
    }
}