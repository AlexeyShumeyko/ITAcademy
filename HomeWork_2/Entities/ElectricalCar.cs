public class ElectricalCar : Car
{
    public TimeSpan TimeWithoutCharge { get; set; }
    public override void Move()
    {
        Console.WriteLine("The car is coming");
    }

    public override void Charge()
    {
        Console.WriteLine("The car is charging");
    }
    public override string ToString()
    {
        return base.ToString() + $"\nTimeWithoutCharge: {TimeWithoutCharge}";
    }
}