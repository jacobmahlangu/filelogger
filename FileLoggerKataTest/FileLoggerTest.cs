using System;
using FileLoggerKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileLoggerKataTest
{
    [TestClass]
    public class FileLoggerTest
    {
        [TestMethod]
        public void LogTest()
        {
            //Setup for Test
            IFileSystem fileSystem = new FileSystem();

            //The units tests wills be testing for the behavior of Log() method.
            //It will simulate the behavior of log() method to test if files are named correctly
            //And test also that message logged is correct for an 8 days period

            //day 1 Saturday
            //Arrange for File Naming Test
            string string_date = "2022/03/26";
            DateTime date = Convert.ToDateTime(string_date);
            string message = "day 1 Saturday";
            string expectedFileName = "weekend.txt";
            IDateProvider dateProvider = new DateProvider(date);
            FileLogger fileLogger = new FileLogger(fileSystem, dateProvider);

            //Act for File Naming Test and Message Test
            string actualMessageLogged = fileLogger.Log(message);

            //Assert for File Naming Test
            Assert.IsTrue(fileSystem.Exists(expectedFileName));

            // Arrange for Logged Message Test
            string expectedMessageLogged = date.ToString("yyyy-MM-dd") + " " + fileSystem.GetLastWriteTime(expectedFileName).ToString("T") + " " + message;

            //Assert for Message Tes
            Assert.AreEqual(expectedMessageLogged, actualMessageLogged);
            Console.WriteLine(expectedMessageLogged + " - Expected");
            Console.WriteLine(actualMessageLogged + " - Actual");

            //day 2 Sunday
            //Arrange for File Naming Test
            string_date = "2022/03/27";
            date = Convert.ToDateTime(string_date);
            message = "day 2 Sunday";
            expectedFileName = "weekend.txt";
            dateProvider = new DateProvider(date);
            fileLogger = new FileLogger(fileSystem, dateProvider);

            //Act for File Naming Test and Message Test
            actualMessageLogged = fileLogger.Log(message);

            //Assert for File Naming Test
            Assert.IsTrue(fileSystem.Exists(expectedFileName));

            // Arrange for Logged Message Test
            expectedMessageLogged = date.ToString("yyyy-MM-dd") + " " + fileSystem.GetLastWriteTime(expectedFileName).ToString("T") + " " + message;

            //Assert for Message Tes
            Assert.AreEqual(expectedMessageLogged, actualMessageLogged);
            Console.WriteLine(expectedMessageLogged + " - Expected");
            Console.WriteLine(actualMessageLogged + " - Actual");


            //day 3 Monday
            //Arrange for File Naming Test
            string_date = "2022/03/28";
            date = Convert.ToDateTime(string_date);
            message = "day 3 Monday";
            expectedFileName = "Log20220328.txt";
            dateProvider = new DateProvider(date);
            fileLogger = new FileLogger(fileSystem, dateProvider);

            //Act for File Naming Test and Message Test
            actualMessageLogged = fileLogger.Log(message);

            //Assert for File Naming Test
            Assert.IsTrue(fileSystem.Exists(expectedFileName));

            // Arrange for Logged Message Test
            expectedMessageLogged = date.ToString("yyyy-MM-dd") + " " + fileSystem.GetLastWriteTime(expectedFileName).ToString("T") + " " + message;

            //Assert for Message Tes
            Assert.AreEqual(expectedMessageLogged, actualMessageLogged);
            Console.WriteLine(expectedMessageLogged + " - Expected");
            Console.WriteLine(actualMessageLogged + " - Actual");


            //day 4 Tuesday
            //Arrange for File Naming Test
            string_date = "2022/03/29";
            date = Convert.ToDateTime(string_date);
            message = "day 4 Tuesday";
            expectedFileName = "Log20220329.txt";
            dateProvider = new DateProvider(date);
            fileLogger = new FileLogger(fileSystem, dateProvider);

            //Act for File Naming Test and Message Test
            actualMessageLogged = fileLogger.Log(message);

            //Assert for File Naming Test
            Assert.IsTrue(fileSystem.Exists(expectedFileName));

            // Arrange for Logged Message Test
            expectedMessageLogged = date.ToString("yyyy-MM-dd") + " " + fileSystem.GetLastWriteTime(expectedFileName).ToString("T") + " " + message;

            //Assert for Message Tes
            Assert.AreEqual(expectedMessageLogged, actualMessageLogged); ;
            Console.WriteLine(expectedMessageLogged + " - Expected");
            Console.WriteLine(actualMessageLogged + " - Actual");


            //day 5 Wednesday
            //Arrange for File Naming Test
            string_date = "2022/03/30";
            date = Convert.ToDateTime(string_date);
            message = "day 5 Wednesday";
            expectedFileName = "Log20220330.txt";
            dateProvider = new DateProvider(date);
            fileLogger = new FileLogger(fileSystem, dateProvider);

            //Act for File Naming Test and Message Test
            actualMessageLogged = fileLogger.Log(message);

            //Assert for File Naming Test
            Assert.IsTrue(fileSystem.Exists(expectedFileName));

            // Arrange for Logged Message Test
            expectedMessageLogged = date.ToString("yyyy-MM-dd") + " " + fileSystem.GetLastWriteTime(expectedFileName).ToString("T") + " " + message;

            //Assert for Message Tes
            Assert.AreEqual(expectedMessageLogged, actualMessageLogged);
            Console.WriteLine(expectedMessageLogged + " - Expected");
            Console.WriteLine(actualMessageLogged + " - Actual");


            //day 6 Thurday
            //Arrange for File Naming Test
            string_date = "2022/03/31";
            date = Convert.ToDateTime(string_date);
            message = "day 6 Thurday";
            expectedFileName = "Log20220331.txt";
            dateProvider = new DateProvider(date);
            fileLogger = new FileLogger(fileSystem, dateProvider);

            //Act for File Naming Test and Message Test
            actualMessageLogged = fileLogger.Log(message);

            //Assert for File Naming Test
            Assert.IsTrue(fileSystem.Exists(expectedFileName));

            // Arrange for Logged Message Test
            expectedMessageLogged = date.ToString("yyyy-MM-dd") + " " + fileSystem.GetLastWriteTime(expectedFileName).ToString("T") + " " + message;

            //Assert for Message Tes
            Assert.AreEqual(expectedMessageLogged, actualMessageLogged);
            Console.WriteLine(expectedMessageLogged + " - Expected");
            Console.WriteLine(actualMessageLogged + " - Actual");


            //day 7 Friday
            //Arrange for File Naming Test
            string_date = "2022/04/01";
            date = Convert.ToDateTime(string_date);
            message = "day 7 Friday";
            expectedFileName = "Log20220401.txt";
            dateProvider = new DateProvider(date);
            fileLogger = new FileLogger(fileSystem, dateProvider);

            //Act for File Naming Test and Message Test
            actualMessageLogged = fileLogger.Log(message);

            //Assert for File Naming Test
            Assert.IsTrue(fileSystem.Exists(expectedFileName));

            // Arrange for Logged Message Test
            expectedMessageLogged = date.ToString("yyyy-MM-dd") + " " + fileSystem.GetLastWriteTime(expectedFileName).ToString("T") + " " + message;

            //Assert for Message Tes
            Assert.AreEqual(expectedMessageLogged, actualMessageLogged);
            Console.WriteLine(expectedMessageLogged + " - Expected");
            Console.WriteLine(actualMessageLogged + " - Actual");


            //day 8 Saturday
            //Arrange for File Naming Test
            string_date = "2022/04/02";
            date = Convert.ToDateTime(string_date);
            message = "day 8 Saturday";
            expectedFileName = "weekend.txt";
            string expectedFileName_lastWeekend = "weekend-20220328.txt";
            dateProvider = new DateProvider(date);
            fileLogger = new FileLogger(fileSystem, dateProvider);

            //Act for File Naming Test and Message Test
            actualMessageLogged = fileLogger.Log(message);

            //Assert for File Naming Test
            Assert.IsTrue(fileSystem.Exists(expectedFileName));

            // Arrange for Logged Message Test
            expectedMessageLogged = date.ToString("yyyy-MM-dd") + " " + fileSystem.GetLastWriteTime(expectedFileName).ToString("T") + " " + message;

            //Assert for Message Tes
            Assert.IsTrue(fileSystem.Exists(expectedFileName_lastWeekend));
            Assert.AreEqual(expectedMessageLogged, actualMessageLogged);
            Console.WriteLine(expectedMessageLogged + " - Expected");
            Console.WriteLine(actualMessageLogged + " - Actual");
        }
    }
}