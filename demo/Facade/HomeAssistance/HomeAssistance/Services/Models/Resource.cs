using System;

namespace HomeAssistance.Services
{
    public class Resource
    {
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public string[] Actors { get; set; }
        public string Director { get; set; }
        public string Sumary { get; set; }
        public string Description { get; set; }
    }
}
