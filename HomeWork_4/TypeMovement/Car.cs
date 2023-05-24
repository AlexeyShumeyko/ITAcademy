public class Car : Transport,IMovable
{
    public override string Move()
    {
        return "Передвижение на машине";
    }
}