using HomeAssistance.Clients;
using HomeAssistance.Services;
using Moq;
using NUnit.Framework;

namespace HomeAssistance.Tests
{
    [TestFixture]
    public class GoogleSpekerTests
    {
        private GoogleSpeaker _googleSpeaker; 
        private Mock<IHomeAssistance> _homeAssistance; 
        
        [SetUp]
        public void Init()
        {
            _homeAssistance = HomeAssistantMock.GetHomeAssistance();
            _googleSpeaker = new GoogleSpeaker(_homeAssistance.Object);
        }

        [Test]
        public void When_WokeUpCommandIsActivated_Expect_WokeHasBeenCalled() {          
            _googleSpeaker.ActivateCommand(VoiceCommand.WokeUp);
            _homeAssistance.Verify(assistance => assistance.WakeUp(), Times.Once);
        }

        [Test]
        public void When_ArriveHomeCommandIsActivated_Expect_ArriveHomeHasBeenCalled()
        {
            _googleSpeaker.ActivateCommand(VoiceCommand.ArriveHomme);
            _homeAssistance.Verify(assistance => assistance.ArriveHome(), Times.Once);
        }

    }
}
