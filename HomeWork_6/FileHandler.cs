public class FileHandler
{
    private int _totalCountWord = 0;
    private object _lock = new object();

    public Task WordCountTextThread (string pathToDirectory)
    {
        var fileList = Directory.GetFiles(pathToDirectory);
        if (fileList.Length == 0)
        {
            Console.WriteLine("File not found");
            return Task.FromResult(0);
        }

        Task[] tasks = new Task[fileList.Length];

        int indexFile = 0;

        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Task.Run(() => WordCountText(fileList[indexFile++]));
        }

        Task.WaitAll(tasks);

        return Task.CompletedTask;
    }

    private void WordCountText(string path)
    {
        string allText;

        var fileInfo = new FileInfo(path);

        using (StreamReader sr = new StreamReader(path))
        {
            allText = sr.ReadToEnd();
        }

        int countWords = allText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

        lock (_lock)
        {
            Console.WriteLine($"\nFile {fileInfo.Name} has finished counting words : {countWords}");
            _totalCountWord += countWords;
            Console.WriteLine($"The total sum of words at the moment is : {_totalCountWord}\n");
        }
    }

}