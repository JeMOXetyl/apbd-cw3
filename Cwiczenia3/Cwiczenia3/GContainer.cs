namespace Cwiczenia3;

public class GContainer : Container, IHazardNotifier
{
    public double Pressure { get; set; }
    
    public GContainer(
        double conHeight, 
        double conWeight,
        double conDepth, 
        double maxWeight, 
        double pressure) : base(
        "G",
            conHeight, 
            conWeight, 
            conDepth, 
            maxWeight)
    {
        Pressure = pressure;
    }

    public override void UnloadContainer()
    {
        LoadWeight *= 0.05;
    }

    public override void LoadContainer(double loadWeight)
    {
        if (loadWeight > MaxWeight)
        {
            AlertDanger(SerialNumber);
            throw new OverfillException($"Max load exceeded for container {SerialNumber}");
        }
        base.LoadContainer(loadWeight);
    }
    
    public override string ToString()
    {
        return base.ToString() + $", Pressure: {Pressure} atm";
    }

    public void AlertDanger(string serialNumber)
    {
        Console.WriteLine($"Dangerous situation in container {serialNumber}");
    }
    
    
}