public class Repository<T> : IRepository<T> where T : Entities
{
    private Dictionary<int, T> _entities = new Dictionary<int, T>();

    public void Add(T entity)
    {
        if (_entities.ContainsKey(entity.Id))
            throw new ArgumentException("This object has already been added");

        _entities.Add(entity.Id, entity);
    }

    public void Delete(T entity)
    {
        if (_entities.Remove(entity.Id))
            Console.WriteLine("Removal successful");
    }

    public List<T> GetAll()
    {
        return _entities.Values.ToList();
    }

    public T GetById(int id)
    {
        if(!_entities.ContainsKey(id))
            throw new NullReferenceException();

        return _entities[id];
    }

    public void Update(T entity)
    {
        if (!_entities.ContainsKey(entity.Id))
            throw new NullReferenceException("Object not found");

        _entities[entity.Id] = entity;
        Console.WriteLine("Object updated");
    }
}