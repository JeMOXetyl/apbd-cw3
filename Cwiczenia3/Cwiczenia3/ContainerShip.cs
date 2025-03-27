namespace Cwiczenia3;

public class ContainerShip
{
    public List<Container> Containers = new List<Container>();
    public double MaxSpeed { get; }
    public int MaxContainerCount { get; }
    public double MaxCargoWeight { get; }

    public ContainerShip(double maxSpeed, 
                        int maxContainerCount, 
                        double maxCargoWeight)
    {
        MaxSpeed = maxSpeed;
        MaxContainerCount = maxContainerCount;
        MaxCargoWeight = maxCargoWeight;
    }

    public void PlaceContainer(Container container)
    {
        if (Containers.Count >= MaxContainerCount)
            throw new Exception("Container ship is full");
        var weight = CalculateWeight();
        if(weight > MaxCargoWeight)
            throw new Exception("Exceeded max cargo weight");
        Containers.Add(container);
    }

    private double CalculateWeight()
    {
        return Containers.Sum(k => (k.LoadWeight + k.ConWeight)) / 1000;
    }

    public void RemoveContainer(string serialNumber)
    {
        var container = Containers.FirstOrDefault(c => c.SerialNumber == serialNumber);
        if (container != null)
        {
            Containers.Remove(container);
        }
    }

    public void ReplaceContainer(string serialNumber, Container container)
    {
        var firstContainer = Containers.FirstOrDefault(c => c.SerialNumber == serialNumber);
        if(firstContainer == null)
            throw new Exception($"Container {serialNumber} doesn't exists");
        var firstWeight = (firstContainer.LoadWeight + firstContainer.ConWeight)/1000;
        var secondWeight = (container.LoadWeight + container.ConWeight)/1000;
        if((CalculateWeight() + firstWeight - secondWeight) > MaxCargoWeight)
            throw new Exception("Exceeded max cargo weight");
        Containers.Remove(firstContainer);
        Containers.Add(container);
    }

    public void MoveContainer(ContainerShip containerShip, string serialNumber)
    {
        var container = Containers.FirstOrDefault(c => c.SerialNumber == serialNumber);
        if (container == null) return;
        RemoveContainer(serialNumber);
        containerShip.PlaceContainer(container);
    }

    public void CargoInfo()
    {
        Console.WriteLine($"Container ship max speed: {MaxSpeed} knots");
        Console.WriteLine($"Container ship max container count: {MaxContainerCount}");
        Console.WriteLine($"Container ship max cargo weight: {MaxCargoWeight}tons");
        Console.WriteLine($"Current container count: {Containers.Count}");
        foreach (var con in Containers)
            Console.WriteLine($" - {con}");
        
        Console.WriteLine($"Current cargo weight: {CalculateWeight()} tons");
    }
    
}