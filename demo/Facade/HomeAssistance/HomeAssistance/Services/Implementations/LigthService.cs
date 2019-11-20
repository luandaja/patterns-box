using System;

namespace HomeAssistance.Services
{
    public class LigthService : ILightService
    {
        public void SwithOffLights()
        {
            Console.WriteLine("Swithing off lights");
        }

        public void SwithOnLights()
        {
            Console.WriteLine("Swithing on lights");
        }
    }
}
