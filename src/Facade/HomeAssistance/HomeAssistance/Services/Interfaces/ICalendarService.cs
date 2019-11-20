using System;
using System.Collections.Generic;

namespace HomeAssistance.Services
{
    public interface ICalendarService
    {
        void AddEvent(DateTime date, string eventName);
        List<string> GetEvents(DateTime date);
        List<string> GetReminders(DateTime date);
    }
}
