var RepositoryPerson = new Repository<Person>();

var person1 = new Person();
var person2 = new Person(23);
var person3 = new Person(45, "Alexey", 20);
var person4 = new Person();

RepositoryPerson.Add(person1);
RepositoryPerson.Add(person2);

try
{
    RepositoryPerson.Delete(person3); // Object not found
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}

RepositoryPerson.Delete(person1); // Removal successful

try
{
    RepositoryPerson.GetById(5); 
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}

RepositoryPerson.GetById(0); // person1

RepositoryPerson.Add(person3);

person3.Age = 23;
RepositoryPerson.Update(person3) ;

try
{
    RepositoryPerson.Update(person4); // not found
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}

var listPerson = new List<Person>();
listPerson = RepositoryPerson.GetAll();

// Product

var RepositoryProduct = new Repository<Product>();

var product1 = new Product();
var product2 = new Product();
var product3 = new Product();

RepositoryProduct.Add(product1);
RepositoryProduct.Add(product2);

try
{
    RepositoryProduct.Delete(product3); // Object not found
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}

RepositoryProduct.Delete(product2); // Removal successful

try
{
    RepositoryProduct.GetById(2);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    RepositoryProduct.Update(product3);
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex);
}

var listProduct = new List<Product>();
listProduct = RepositoryProduct.GetAll();

RepositoryProduct.Add(product2);
RepositoryProduct.Delete(product2);