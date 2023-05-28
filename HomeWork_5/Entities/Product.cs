public class Product
{
    private int Id { get; set; }
    private string Name { get; set; }

    public Product()
    {

    }
    public Product(int id)
    {
        Id = id;
    }
    public Product(int id, string name) : this(id)
    {
        Name = name;
    }
}