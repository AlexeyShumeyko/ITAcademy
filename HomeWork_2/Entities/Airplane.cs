public class Airplane : FlyingVehical
{
    public int NumberOfEngines { get; set; }
    public int NumberOfPersons { get; set; }
    public string Name { get; set; }

    public override void Move()
    {
        Console.WriteLine("Airplane is flying");
    }
    public override void GetMechanismOfFly()
    {
        Console.WriteLine("Wing and airflow");
    }
    public override string ToString()
    {
        return base.ToString() + $"\nNumberOfEngines: {NumberOfEngines} \nNumberOfPersons: {NumberOfPersons} \nName: {Name}";
    }
}