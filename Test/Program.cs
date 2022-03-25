using FileLoggerKata;
class Program
{
    static void Main(string[] args)
    {
        IFileSystem fileSystem = new FileSystem();
        IDateProvider dateProvider = new DateProvider();
        FileLogger fileLogger = new FileLogger(fileSystem, dateProvider);
        fileLogger.Log("test");
        Console.WriteLine(dateProvider.Today);

    }
}