using Adapter.Models.Requests;

namespace Adapter.ThirdPartyAPI
{
    public class HipaaExternalClient
    {
        public string GetHipaaResponse(HipaaRequest request)
        {
            return request.ClaimDescription + "--Processed";
        }
    }
}
