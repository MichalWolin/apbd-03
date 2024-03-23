using Cw03.Exceptions;
using Cw03.Interfaces;

namespace Cw03;

public abstract class Container : IContainer
{
    public double CargoWeight { get; set; }

    public double Height { get; set; }
    public double Weight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; set; }
    public double MaxCargoWeight { get; set; }
    private static int _serialNumberId = 1;

    protected Container(double height, double weight, double depth, string containerType, double maxCargoWeight)
    {
        Height = height;
        Weight = weight;
        Depth = depth;
        SerialNumber = "KON-" + containerType + "-" + _serialNumberId++;
        MaxCargoWeight = maxCargoWeight;
    }

    public virtual void Unload()
    {
        CargoWeight = 0;
    }

    public virtual void Load(double cargoWeight)
    {
        if (CargoWeight + cargoWeight > MaxCargoWeight)
            throw new OverfillException();

        CargoWeight += cargoWeight;
    }

    public override string ToString()
    {
        return "Container: " + SerialNumber + ", Weight (kg): " + Weight + ", Height (cm): " + Height + ", Depth (cm): "
               + Depth + ", MaxCargoWeight (kg): " + MaxCargoWeight + ", CargoWeight (kg): " + CargoWeight;
    }
}