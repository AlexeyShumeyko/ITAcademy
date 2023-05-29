public class Person : Entities
{
    private string Name { get; set; }
    private int Age { get; set; }

    public Person(int id)
    {
        Id = id;
    }
    public Person(int id, string name, int age) : this(id)
    {
        Name = name;
        Age = age;
    }
}