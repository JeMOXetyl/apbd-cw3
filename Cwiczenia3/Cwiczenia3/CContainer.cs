namespace Cwiczenia3;

public class CContainer : Container
{
    private string _product;
    public double Temperature { get; }
    public CContainer(
        double conHeight, 
        double conWeight,
        double conDepth, 
        double maxWeight,
        string product,
        double temperature) : base(
        "C",
        conHeight, 
        conWeight, 
        conDepth, 
        maxWeight)
    {
        _product = product;
        Temperature = temperature;
    }

    public override void LoadContainer(double loadWeight)
    {
        if (LoadWeight > 0 && loadWeight > 0)
            throw new Exception($"Container {SerialNumber} can only store one type of product at once");
        base.LoadContainer(loadWeight);
    }

    public override string ToString()
    {
        return base.ToString() + $" Product: {_product}, Temperature: {Temperature} Celsius";
    }
}