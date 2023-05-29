var repositoryPerson = new Repository<Person>();

var person1 = new Person(12, "vcbcv", 26);
var person2 = new Person(23, "derfc", 18);
var person3 = new Person(45, "Alexey", 20);
var person4 = new Person(23, "vbbnb", 37);

repositoryPerson.Add(person1);
repositoryPerson.Add(person2);
repositoryPerson.Add(person3);

person1 = new Person(35, "sadsdf", 22);

repositoryPerson.Add(person1);
try
{
    repositoryPerson.Add(person4);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    repositoryPerson.Update(person4);
}

repositoryPerson.Delete(person3);
repositoryPerson.Delete(person3);

try
{
    repositoryPerson.GetById(0);
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}

repositoryPerson.GetById(person2.Id);


var listPerson = new List<Person>();
listPerson = repositoryPerson.GetAll();

// Product

var repositoryProduct = new Repository<Product>();

var product1 = new Product(12, "dfdf");
var product2 = new Product(15, "bnmvbn");

repositoryProduct.Add(product1);
repositoryProduct.Add(product2);

var list = new List<Product>();
list = repositoryProduct.GetAll();

product1 = new Product(12, "zxzx");

try
{
    repositoryProduct.Add(product1);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    repositoryProduct.Update(product1);
}

Console.WriteLine(String.Join("", list));