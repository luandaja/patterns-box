using HomeAssistance.Services;
using Moq;

namespace HomeAssistance.Tests
{
    internal static class HomeAssistantMock
    {
        internal static Mock<IHomeAssistance> GetHomeAssistance()
        {
            var homeAssistance = new Mock<IHomeAssistance>();
            homeAssistance.Setup(assistance => assistance.ArriveHome())
                          .Verifiable();
            homeAssistance.Setup(assistance => assistance.WakeUp())
                          .Verifiable();
            return homeAssistance;
        }
    }
}
