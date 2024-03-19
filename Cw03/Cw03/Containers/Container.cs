using Cw03.Exceptions;
using Cw03.Interfaces;

namespace Cw03;

public abstract class Container : IContainer
{
    public double CargoWeight { get; set; }

    public double CargoHeight { get; set; }

    protected Container(double cargoWeight, double cargoHeight)
    {
        CargoWeight = cargoWeight;
        CargoHeight = cargoHeight;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public void Load(double cargoWeight)
    {
        throw new OverfillException();
    }
}