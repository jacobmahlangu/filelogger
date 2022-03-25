using System;

namespace FileLoggerKata
{
    public interface IDateProvider
    {
        DateTime Today { get; }
    }
    public class DateProvider : IDateProvider
    {
        private DateTime _today;
        public DateTime Today
        {
            get => _today; 
        }
        public DateProvider() => _today = DateTime.Today;
    }
}