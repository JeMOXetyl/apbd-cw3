namespace Cwiczenia3;

public class Container
{
    private static Dictionary<string, int> _types = new Dictionary<string, int>();
    public string SerialNumber { get; }
    public double LoadWeight { get; set; }
    public double ConHeight { get; }
    public double ConWeight { get; }
    public double ConDepth { get; }
    public string ConNumber { get; }
    public double MaxWeight { get; }

    protected Container(string type, 
                        double conHeight, 
                        double conWeight, 
                        double conDepth, 
                        double maxWeight)
    {
        _types.TryAdd(type, 1);
        SerialNumber = $"KON-{type}-{_types[type]++}";
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
        LoadWeight += loadWeight;
    }

    public override string ToString()
    {
        return $"{SerialNumber}, max weight: {MaxWeight}kg, load weight: {LoadWeight}kg";
    }
}