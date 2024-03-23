namespace Cw03;

public class ContainerShip
{
    public string ShipName { get; set; }
    private List<Container> _containers;
    public int MaxSpeed { get; set; }
    public int MaxContainers { get; set; }
    public double MaxCargoWeight { get; set; }

    public ContainerShip(string shipName, int maxSpeed, int maxContainers, double maxCargoWeight)
    {
        ShipName = shipName;
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxCargoWeight = maxCargoWeight;
        _containers = new List<Container>();
    }

    public void LoadContainer(Container container)
    {
        if (_containers.Count < MaxContainers && container.Weight <= MaxCargoWeight)
            _containers.Add(container);
        else
            Console.WriteLine("Cannot load container: " + container.SerialNumber + " on ship: " + ShipName);
    }

    public void LoadContainers(List<Container> containers)
    {
        foreach (var container in containers)
            LoadContainer(container);
    }

    public void UnloadContainer(Container container)
    {
        _containers.Remove(container);
    }

    public void ReplaceContainer(Container oldContainer, Container newContainer)
    {
        _containers.Remove(oldContainer);
        LoadContainer(newContainer);
    }

    public void MoveContainer(Container container, ContainerShip otherShip)
    {
        UnloadContainer(container);
        otherShip.LoadContainer(container);
    }

    public override string ToString()
    {
        return "ContainerShip: " + ShipName + " MaxSpeed (knots): " + MaxSpeed + " MaxContainers: "
               + MaxContainers + " MaxCargoWeight (kg): " + MaxCargoWeight + " Containers: " + _containers.Count
               + " Loaded weight (kg): " + _containers.Sum(c => c.Weight);
    }
}