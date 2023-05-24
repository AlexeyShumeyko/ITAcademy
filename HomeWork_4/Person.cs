public class Person : IMovable
{
    private Transport _Transport { get; set; }

    public Person()
    {

    }

    public Person (Transport transport)
    {
        _Transport = transport;
    }

    public string Move()
    {
        if (_Transport == null)
            return "Объект Person. Передвигается пешком";

        return $"Объект Person. {_Transport.Move()}";
    }
}