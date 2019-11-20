using System;

namespace HomeAssistance.Services.Facade
{
    public class HomeAssistance: IHomeAssistance
    { 
        private readonly ICalendarService _calendarService;
        private readonly ISpotifyService _spotifyService;
        private readonly ILightService _lightService;

        public HomeAssistance( ICalendarService calendarService, ISpotifyService spotifyService, ILightService lightService)
        {
            _calendarService = calendarService;
            _spotifyService = spotifyService;
            _lightService = lightService;
        }

        public void AddRoutine() { }

        public void WakeUp() {
            _lightService.SwithOnLights();
            _calendarService.GetEvents(DateTime.Today);
            _calendarService.GetReminders(DateTime.Today);
            int morningPlaylist = 1;
            _spotifyService.Play(morningPlaylist);
        }

        public void ArriveHome()
        {
            _lightService.SwithOnLights();
            _spotifyService.Play();
        }

    }
}
