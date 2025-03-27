namespace Cwiczenia3;

public class CContainer : Container
{
    private string _product;
    private double Temperature { get; set; }
    public CContainer(
        double conHeight, 
        double conWeight,
        double conDepth, 
        double maxWeight,
        string product,
        double temperature) : base(
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
        base.LoadContainer(loadWeight);
    }
}