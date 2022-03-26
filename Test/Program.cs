using FileLoggerKata;
class Program
{
    static void Main(string[] args)
    {
        //Run Project for Manual Testing
        string string_date = "2022/03/26";
        DateTime date = Convert.ToDateTime(string_date);
        string message = "day 1 Saturday";
        IDateProvider dateProvider = new DateProvider(date);
        IFileSystem fileSystem = new FileSystem();
        FileLogger fileLogger = new FileLogger(fileSystem, dateProvider);
        string expectedFileName = "weekend.txt";
        string actualMessageLogged = fileLogger.Log(message);
        Console.WriteLine("The following " + actualMessageLogged + "was logged in file " + expectedFileName);


    }
}