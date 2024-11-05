public class Car
{
    public string Brand { get; private set; }
    public string Model { get; private set; }
    public DateTime ProductionDate { get; private set; }
    public Car(string brand, string model, DateTime productiondate)
    {
        Brand = brand;
        Model = model;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Marka:{Brand}, Model: {Model}, Data Produkcji: {ProductionDate.ToShortDateString()}");
    }
}