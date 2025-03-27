namespace Cwiczenia3;

public class GContainer : Container, IHazardNotifier
{
    private double Pressure { get; set; }
    
    public GContainer(
        double conHeight, 
        double conWeight,
        double conDepth, 
        double maxWeight, 
        double pressure) : base(
            conHeight, 
            conWeight, 
            conDepth, 
            maxWeight)
    {
        Pressure = pressure;
    }

    public override void UnloadContainer()
    {
        
    }
    
    public void AlertDanger(string serialNumber)
    {
        Console.WriteLine($"Dangerous situation in container {serialNumber}");
    }
}