public class Person : Transport
{
    public Transport _Transport { get; set; }

    public override string Move()
    {
        if (_Transport?.GetType() == typeof(Car))
        {
            return "Человек едет на машине";
        }
        else if (_Transport?.GetType() == typeof(Boat))
        {
            return "Человек плывёт на лодке";
        }
        else
        {
            return "Человек идёт пешком";
        }
    }
}