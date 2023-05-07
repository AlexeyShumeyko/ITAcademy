public class Helicopter : FlyingVehical
{
    public int NumberOfBlades { get; set; }
    public override void Move()
    {
        Console.WriteLine("Helicopter is flying");
    }
    public override void GetMechanismOfFly()
    {
        Console.WriteLine("Helicopter blades");
    }
    public override string ToString()
    {
        return base.ToString() + $"\nNumberOfBlades: {NumberOfBlades}";
    }
}