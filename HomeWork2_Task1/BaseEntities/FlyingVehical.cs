public abstract class FlyingVehical : Vehical
{
    public double MaxLiftingHeight { get; set; }

    public abstract void GetMechanismOfFly();

    public override string ToString()
    {
        return base.ToString() + $"\nMaxLiftingHeight: {MaxLiftingHeight}";
    }
}