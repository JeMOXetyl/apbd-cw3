namespace Cwiczenia3;

public class Container
{
    private string SerialNumber { get; set; }
    private double LoadWeight { get; set; }
    private double ConHeight { get; set; }
    private double ConWeight { get; set; }
    private double ConDepth { get; set; }
    private string ConNumber { get; set; }
    private double MaxWeight { get; set; }

    public Container(double conHeight, double conWeight, double conDepth, double maxWeight)
    {
        SerialNumber = $"KON-";
        ConHeight = conHeight;
        ConWeight = conWeight;
        ConDepth = conDepth;
        MaxWeight = maxWeight;
    }

    public virtual void UnloadContainer()
    {
        LoadWeight = 0;
    }

    public virtual void LoadContainer(double loadWeight)
    {
        if (loadWeight > MaxWeight)
            throw new OverfillException("Max load exceeded");
        LoadWeight = loadWeight;
    }

    public override string ToString()
    {
        return $"{SerialNumber}, load weight: {LoadWeight}kg";
    }
}