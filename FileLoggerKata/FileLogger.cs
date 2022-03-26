using System;

namespace FileLoggerKata
{
    public class FileLogger
    {
        private const string LogExtension = "txt";
        private const string LogFileName = "log";
        private const string WeekendLogFileName = "weekend";

        private IDateProvider DateProvider { get; }
        private IFileSystem FileSystem { get; }

        public FileLogger(IFileSystem fileSystem, IDateProvider dateProvider = null)
        {
            DateProvider = dateProvider ?? DefaultDataProvider.Instance;
            FileSystem = fileSystem;
        }

        public string Log(string message)
        {
                var logFileName = GetLogFileName();
                //var logFileName = LogFileName + "." + LogExtension;

                if (ShouldRotateWeekendLogs())
                {
                    ArchiveWeekendLog();
                }

                if (!FileSystem.Exists(logFileName))
                {
                    FileSystem.Create(logFileName);
                }
                message = FormatMessageDateTime(message);

                FileSystem.Append(logFileName, message);

                bool ShouldRotateWeekendLogs()
                {
                    return IsWeekend(DateProvider.Today) &&
                           FileSystem.Exists(logFileName) &&
                           (DateProvider.Today - FileSystem.GetLastWriteTime(logFileName)).Days > 2;
                }
            return message;
        }

        private string GetLogFileName()
        {
            var today = DateProvider.Today;

            return IsWeekend(today)
                ? $"{WeekendLogFileName}.{LogExtension}"
                : $"{LogFileName}{ToFileDateFormat(today)}.{LogExtension}";            
        }

        private void ArchiveWeekendLog()
        {
            var lastWriteTime = FileSystem.GetLastWriteTime($"{WeekendLogFileName}.{LogExtension}");
            var archivedFileName = $"{WeekendLogFileName}-{ToFileDateFormat(lastWriteTime)}.{LogExtension}";
            FileSystem.Rename($"{WeekendLogFileName}.{LogExtension}", archivedFileName);
        }
        public string FormatMessageDateTime(string message)
        {
            return DateProvider.Today.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("T") + " " + message;
        }

        private static string ToFileDateFormat(DateTime date)
        {
            return date.ToString("yyyyMMdd");
        }

        private static bool IsWeekend(DateTime date) => date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        
    }

}

