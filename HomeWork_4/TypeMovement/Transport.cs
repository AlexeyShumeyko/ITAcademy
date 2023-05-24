public class Transport : IMovable
{
    public int MaxSpid { get; set; }

    public virtual string Move()
    {
        return "Транспорт передвигается";
    }
}