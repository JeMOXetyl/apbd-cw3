namespace Cwiczenia3;

class Program
{
    static void Main(string[] args)
    {
        var ship1 = new ContainerShip(25, 5, 300);
        var ship2 = new ContainerShip(30, 3, 200);

        var con1 = new LContainer(200, 1000, 500, 20000, false);
        con1.LoadContainer(18000);
            
            
        var con2 = new CContainer(250, 1500, 600, 25000, "Bananas", 13.3);
        con2.LoadContainer(20000);

        ship1.PlaceContainer(con1);
        ship1.PlaceContainer(con2);
         
        var con3 = new GContainer(300, 2000, 700, 15000, 2.5);
        ship1.ReplaceContainer(con1.SerialNumber, con3);
        ship1.MoveContainer(ship2, con2.SerialNumber);
        
        Console.WriteLine(con3);
        Console.WriteLine(con2);
        Console.WriteLine(con1);
        
        ship1.CargoInfo();
        ship2.CargoInfo();
        ship2.RemoveContainer(con2.SerialNumber);
        con2.UnloadContainer();
        Console.WriteLine(con2);
    }
}