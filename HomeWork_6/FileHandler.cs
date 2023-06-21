public class FileHandler
{
    private int _totalCountWord = 0;
    private object _locker = new object();

    public Task WordCountTextThread (string pathToDirectory)
    {
        int minWorker, minIOC;
        minWorker = minIOC = Environment.ProcessorCount;

        var fileList = Directory.GetFiles(pathToDirectory);
        if (fileList.Length == 0)
        {
            Console.WriteLine("File not found");
            return Task.FromResult(0);
        }

        Task[] tasks = new Task[fileList.Length];

        if (ThreadPool.SetMinThreads(minWorker, minIOC))
        {
            Console.WriteLine("The minimum number of threads was set successfully.");
        }

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
        int countWordsFile = 0;

        var fileInfo = new FileInfo(path);

        using (StreamReader sr = new StreamReader(path))
        {
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                int countWord = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

                lock (_locker)
                {
                    countWordsFile += countWord;
                }
            }
        }

        lock (_locker)
        {
            Console.WriteLine($"\nFile {fileInfo.Name} has finished counting words : {countWordsFile}");
            _totalCountWord += countWordsFile;
            Console.WriteLine($"The total sum of words at the moment is : {_totalCountWord}\n");
        }
    }

}