public abstract class Car : Vehical
{
    public int WeelsNumber { get; set; }
    public override string ToString()
    {
        return base.ToString() + $"\nWeels Number: {WeelsNumber}";
    }
    public abstract void Charge();
}
