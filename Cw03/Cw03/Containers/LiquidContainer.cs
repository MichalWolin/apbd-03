using Cw03.Interfaces;

namespace Cw03.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    public LiquidContainer(double height, double weight, double depth, double maxCargoWeight)
        : base(height, weight, depth, "L", maxCargoWeight)
    {
    }

    public void NotifyAboutHazard(string message)
    {
        Console.WriteLine(message);
    }

    public void Load(double cargoWeight, bool hazardous)
    {
        if (hazardous)
        {
            if (cargoWeight > MaxCargoWeight * 0.5)
                NotifyAboutHazard("Attempted to load hazardous cargo over 50% of " +
                                  "the maximum capacity in a liquid container " + SerialNumber);
            else
                base.Load(cargoWeight);
        }
        else
        {
            if (cargoWeight > MaxCargoWeight * 0.9)
                NotifyAboutHazard("Attempted to load non-hazardous cargo over 90% of " +
                                  "the maximum capacity in a liquid container " + SerialNumber);
            else
                base.Load(cargoWeight);
        }
    }
}