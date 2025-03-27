namespace Cwiczenia3;

public class LContainer : Container, IHazardNotifier
{
    private bool IsDangerous { get; set; }
    public LContainer(
        double conHeight, 
        double conWeight, 
        double conDepth, 
        double maxWeight,
        bool isDangerous) : base(
            conHeight, 
            conWeight, 
            conDepth,
            maxWeight)
    {
        IsDangerous = isDangerous;
    }

    public override void LoadContainer(double loadWeight)
    {

    }
    
    public void AlertDanger(string serialNumber)
    {
        Console.WriteLine($"Dangerous situation in container {serialNumber}");
    }
}