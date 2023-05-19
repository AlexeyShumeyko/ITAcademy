public abstract class Vehical
{
    public int SpeedMax { get; set; }
    public double Weight { get; set; }
    public double Long { get; set; }
    public double Height { get; set; }
    public TimeSpan Acceleration { get; set; }

    public abstract void Move();

    public override string ToString()
    {
        return $"Weight: {Weight} \nLong: {Long} \nHeight: {Height} \nMax Speed: {SpeedMax} \nAcceleration: {Acceleration}";
    }
}