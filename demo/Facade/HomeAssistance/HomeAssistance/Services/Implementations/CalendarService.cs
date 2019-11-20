using System;
using System.Collections.Generic;

namespace HomeAssistance.Services
{
    public class CalendarService : ICalendarService
    {
        public void AddEvent(DateTime date, string eventName)
        {
            Console.WriteLine("Event added");
        }

        public List<string> GetEvents(DateTime date)
        {
            return new List<string> { "Event 1", "Event 2", "Event 3" };
        }

        public List<string> GetReminders(DateTime date)
        {
            return new List<string> { "Reminder 1", "Reminder 2" };
        }
    }
}
