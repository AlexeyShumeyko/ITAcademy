public class Product : Entities
{
    private string Name { get; set; }

    public Product(int id)
    {
        Id = id;
    }
    public Product(int id, string name) : this(id)
    {
        Name = name;
    }
}