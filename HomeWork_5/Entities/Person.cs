public class Person
{
    private int Id { get; set; }
    private string Name { get; set; }
    public int Age { get; set; }

    public Person()
    {

    }
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