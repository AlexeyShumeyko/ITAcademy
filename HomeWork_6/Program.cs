string pathToDirectory = InputUser();

var test = new FileHandler();
test.WordCountTextThread(pathToDirectory);

static string InputUser()
{
    bool state = true;
    string pathToDirectory;

    do
    {
        Console.WriteLine("Specify the path to the directory");
        pathToDirectory = Console.ReadLine();

        if (Directory.Exists(pathToDirectory))
        {
            state = false;
        }
        else
        {
            Console.WriteLine("Directory not found or incorrect directory path");
            Console.WriteLine("Press key to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
    while (state);

    return pathToDirectory;
}