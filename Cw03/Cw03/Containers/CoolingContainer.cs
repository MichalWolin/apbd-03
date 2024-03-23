namespace Cw03.Containers;

public class CoolingContainer : Container
{
    public CoolingContainer(double height, double weight, double depth, double maxCargoWeight)
        : base(height, weight, depth, "C", maxCargoWeight)
    {
    }

    public double? GetTemperature(PossibleProducts product)
    {
        switch (product)
        {
            case PossibleProducts.Banana: return 13.3;
            case PossibleProducts.Chocolate: return 18.0;
            case PossibleProducts.Fish: return 2.0;
            case PossibleProducts.Meat: return -15.0;
            case PossibleProducts.IceCream: return -18.0;
            case PossibleProducts.FrozenPizza: return -30.0;
            case PossibleProducts.Cheese: return 7.2;
            case PossibleProducts.Sausages: return 5.0;
            case PossibleProducts.Butter: return 20.5;
            case PossibleProducts.Eggs: return 19.0;
        }

        return null;
    }
}