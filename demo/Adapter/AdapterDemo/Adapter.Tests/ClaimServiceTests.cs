using Adapter.Adapters;
using Adapter.Models.Requests;
using FluentAssertions;
using NUnit.Framework;

namespace Adapter.Tests
{
    [TestFixture]
    public class ClaimServiceTests
    {
        private ClaimService _service;

        [SetUp]
        public void Configuration()
        {
        }

        [Test]
        public void ProcessClaim_WithHipaaClient_ReturnProcessedClaim()
        {
            //Arrange
            var hipaaAdapter = new HipaaAdapter();
            _service = new ClaimService(hipaaAdapter);
            var request = new ClaimRequest { ClaimStatus = 1, Locationid = 99, ProviderId = 99 };

            //Action
            var result = _service.ProcessClaim(request);

            //Assert
            result.Should().Be("1//99//99//Processed");
        }

        [Test]
        public void ProcessClaim_WithHipaaExternalClient_ReturnProcessedClaim()
        {
            //Arrange
            var hipaaAdapter = new HipaaExternalAdapter();
            _service = new ClaimService(hipaaAdapter);
            var request = new ClaimRequest { ClaimStatus = 1, Locationid = 99, ProviderId = 99 };

            //Action
            var result = _service.ProcessClaim(request);

            //Assert
            result.Should().Be("1--99--99--Processed");
        }
    }
}
