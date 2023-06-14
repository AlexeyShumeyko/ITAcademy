using System.Text.Json;

public class FileSystemHandler
{
    private void СreateFile(string fileLocation)
    {
        File.Create(fileLocation).Close(); //
    }

    public Dictionary<int, T> GetInfoFromFile<T>(string fileLocation)
    {
        var dictionaryObj = new Dictionary<int, T>();

        if (!File.Exists(fileLocation))
            СreateFile(fileLocation);

        string jsonString = File.ReadAllText(fileLocation);

        if(jsonString == String.Empty)
            return dictionaryObj;

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

    public void SaveDataToFile<T>(Dictionary<int, T> entities, string fileLocation)
    {
        if (!File.Exists(fileLocation))
            СreateFile(fileLocation);

        try
        {
            string jsonString = JsonSerializer.Serialize(entities);
            File.WriteAllText(fileLocation, jsonString);
        }
        catch (JsonException ex)
        {
            Console.WriteLine(ex);
        }
    }
}