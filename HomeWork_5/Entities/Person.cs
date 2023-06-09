public class Person : Entities
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(int id, string name, int age)
    {
        Name = name;
        Age = age;
        Id = id;
    }
}