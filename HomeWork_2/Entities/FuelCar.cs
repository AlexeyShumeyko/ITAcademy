public class FuelCar : Car
{
    public double EngineCapacity { get; set; }
    public double ExpensesPerHungredKM { get; set; }
    public override void Move()
    {
        Console.WriteLine("The car is coming");
    }
    public override void Charge()
    {
        Console.WriteLine("The car is refueling");
    }
    public override string ToString()
    {
        return base.ToString() + $"\nEngineCapacity: {EngineCapacity} \nExpensesPerHungredKM: {ExpensesPerHungredKM}";
    }
}