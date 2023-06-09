using System.Text.Json;

public class FileSystemHandler
{
    private string _pathToFile = "";
    private readonly string _fileName = "entities.json";

    private void СreateFile()
    {
        File.Create(_pathToFile).Close();
    }

    public Dictionary<int,T> GetInfoFromFile<T>(string fileLocation) where T : Entities
    {
        _pathToFile = Path.Combine(fileLocation, _fileName);

        if (!File.Exists(_pathToFile)) 
            throw new FileNotFoundException("File Not Found");

        string jsonString = File.ReadAllText(_pathToFile);

        var dictionaryObj = new Dictionary<int,T>();

        try
        {
            dictionaryObj = JsonSerializer.Deserialize<Dictionary<int, T>>(jsonString);
        }
        catch (JsonException ex)
        {
            Console.WriteLine(ex);
        }

        return dictionaryObj;
    }

    public void SaveDataToFile<T>(Dictionary<int, T> entities, string fileLocation) where T : Entities
    {
        _pathToFile = Path.Combine(fileLocation, _fileName);

        if (!File.Exists(_pathToFile))
            СreateFile();

        try
        {
            string jsonString = JsonSerializer.Serialize(entities);
            File.WriteAllText(_pathToFile, jsonString);
        }
        catch(JsonException ex)
        {
            Console.WriteLine(ex);
        }
    }
}