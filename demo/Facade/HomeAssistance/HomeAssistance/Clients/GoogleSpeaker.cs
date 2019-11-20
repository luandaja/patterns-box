using HomeAssistance.Services;
using System;

namespace HomeAssistance.Clients
{
    public class GoogleSpeaker
    {
        private readonly IHomeAssistance _homeAssistance;
       
        public GoogleSpeaker(IHomeAssistance homeAssistance)
        {
            _homeAssistance = homeAssistance;
        }
         

        public void ActivateCommand(VoiceCommand voiceCommand)
        { 
            //We could apply here strategy pattern to remove axiomatic complexity
            if (voiceCommand == VoiceCommand.WokeUp) {
                Console.WriteLine("Good morning!. Your setup routine it's about to start!");
                _homeAssistance.WakeUp();
            }
              
            if (voiceCommand == VoiceCommand.ArriveHomme)
            {
                Console.WriteLine("Welcome home!");
                _homeAssistance.ArriveHome();
            }               
        }
    }
}
