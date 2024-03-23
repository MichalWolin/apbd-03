namespace Cw03.Containers;

public class LiquidContainer : Container
{
    public LiquidContainer(double height, double weight, double depth, double maxCargoWeight)
        : base(height, weight, depth, "L", maxCargoWeight)
    {
    }
}