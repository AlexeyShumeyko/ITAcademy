public class Repository<T> : IRepository<T> where T : Entities
{
    private FileSystemHandler _fileSystemHandler = new FileSystemHandler();
    private readonly string _fileLocation = $"{typeof(T)}.json";

    public void Add(T entity)
    {
        var dictEntities = _fileSystemHandler.GetInfoFromFile<T>(_fileLocation);

        if (dictEntities.ContainsKey(entity.Id))
            throw new ArgumentException("This object has already been added");

        dictEntities.Add(entity.Id, entity);

        _fileSystemHandler.SaveDataToFile(dictEntities, _fileLocation);
    }

    public void Delete(T entity)
    {
        var dictEntities = _fileSystemHandler.GetInfoFromFile<T>(_fileLocation);

        if (dictEntities.Remove(entity.Id))
        {
            _fileSystemHandler.SaveDataToFile(dictEntities, _fileLocation);
            Console.WriteLine("Removal successful");
        }
    }

    public List<T> GetAll()
    {
        var dictEntities = _fileSystemHandler.GetInfoFromFile<T>(_fileLocation);

        return dictEntities.Values.ToList();
    }

    public T GetById(int id)
    {
        var dictEntities = _fileSystemHandler.GetInfoFromFile<T>(_fileLocation);

        if(!dictEntities.ContainsKey(id))
            throw new NullReferenceException();

        return dictEntities[id];
    }

    public void Update(T entity)
    {
        var dictEntities = _fileSystemHandler.GetInfoFromFile<T>(_fileLocation);

        if (!dictEntities.ContainsKey(entity.Id))
            throw new NullReferenceException("Object not found");

        dictEntities[entity.Id] = entity;

        _fileSystemHandler.SaveDataToFile(dictEntities, _fileLocation);
        Console.WriteLine("Object updated");
    }
}