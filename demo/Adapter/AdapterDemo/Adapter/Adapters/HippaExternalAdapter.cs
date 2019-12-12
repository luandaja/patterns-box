using Adapter.Models.Requests;
using Adapter.ThirdPartyAPI;

namespace Adapter.Adapters
{
    public class HipaaExternalAdapter : IHipaaAdapter
    {
        private readonly HipaaExternalClient _hipaaClient;
        public HipaaExternalAdapter()
        {
            _hipaaClient = new HipaaExternalClient();
        }
        public string GetHipaaResponse(ClaimRequest request)
        {
            var hipaaRequest = new HipaaRequest
            {
                ClaimDescription = string.Concat(
                    request.ClaimStatus,
                    "--",
                    request.Locationid.ToString(),
                    "--",
                    request.ProviderId.ToString())
            };

            return _hipaaClient.GetHipaaResponse(hipaaRequest);
        }
    }
}
