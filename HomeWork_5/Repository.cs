public class Repository<T> : IRepository<T> where T : class
{
    private List<T> entities = new List<T>();

    public void Add(T entity)
    {
        entities.Add(entity);
    }

    public void Delete(T entity)
    {
        if (entities.Remove(entity))
        {
            Console.WriteLine("Removal successful");
        }
        else
        {
            throw new NullReferenceException("Object not found");
        }
    }

    public List<T> GetAll()
    {
        return entities;
    }

    public T GetById(int id)
    {
        return entities[id];
    }

    public void Update(T entity)
    {
        if (entities.Contains(entity))
        {
            int id = entities.IndexOf(entity);
            entities[id] = entity;

            Console.WriteLine("Object updated");
        }
        else
        {
            throw new NullReferenceException("Object not found");
        }
    }
}