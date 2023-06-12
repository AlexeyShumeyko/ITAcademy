public class Repository<T> : IRepository<T> where T : Entities
{
    private static Dictionary<int, T> _entities = new Dictionary<int, T>();
    private FileSystemHandler _fileSystemHandler = new FileSystemHandler();
    private readonly string _fileLocation = $"{typeof(T)}.json";

    public void Add(T entity)
    {
        if (_entities.ContainsKey(entity.Id))
            throw new ArgumentException("This object has already been added");

        _entities.Add(entity.Id, entity);

        _fileSystemHandler.SaveDataToFile(_entities, _fileLocation);
    }

    public void Delete(T entity)
    {
        if (_entities.Remove(entity.Id))
        {
            _fileSystemHandler.SaveDataToFile(_entities, _fileLocation);
            Console.WriteLine("Removal successful");
        }
    }

    public List<T> GetAll()
    {
        return _entities.Values.ToList();
    }

    public T GetById(int id)
    {
        var objCollection = _fileSystemHandler.GetInfoFromFile<T>(_fileLocation);

        if(!objCollection.ContainsKey(id))
            throw new NullReferenceException();

        return objCollection[id];
    }

    public void Update(T entity)
    {
        if (!_entities.ContainsKey(entity.Id))
            throw new NullReferenceException("Object not found");

        _entities[entity.Id] = entity;
        _fileSystemHandler.SaveDataToFile(_entities, _fileLocation);
        Console.WriteLine("Object updated");
    }
}