namespace Cwiczenia3;

public class LContainer : Container, IHazardNotifier
{
    public bool IsDangerous { get; }
    public LContainer(
        double conHeight, 
        double conWeight, 
        double conDepth, 
        double maxWeight,
        bool isDangerous) : base(
        "L",
            conHeight, 
            conWeight, 
            conDepth,
            maxWeight)
    {
        IsDangerous = isDangerous;
    }

    public override void LoadContainer(double loadWeight)
    {
        double maxWeight = IsDangerous ? MaxWeight * 0.5 : MaxWeight * 0.9 ;

        if (loadWeight > maxWeight)
        {
            AlertDanger(SerialNumber);
            throw new OverfillException($"Max load exceeded for container {SerialNumber}");
        }
        base.LoadContainer(loadWeight);
    }
    
    public override string ToString()
    {
        return base.ToString() + $", Dangerous: {IsDangerous}";
    }
    
    public void AlertDanger(string serialNumber)
    {
        Console.WriteLine($"Dangerous situation in container {serialNumber}");
    }
}