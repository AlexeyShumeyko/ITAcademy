public class Product : Entities
{
    public string Name { get; set; }

    public Product(int id, string name)
    {
        Name = name;
        Id = id;
    }
}