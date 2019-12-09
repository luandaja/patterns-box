using Adapter.Models.Requests;
using Adapter.ThirdPartyAPI;

namespace Adapter
{
    public class ClaimService
    {
        private readonly HipaaClient _hipaaClient;
        public ClaimService()
        {
            _hipaaClient = new HipaaClient();
        }

        public void AddClaim(ClaimRequest request)
        {

            _hipaaClient.GetHipaaResponse(request);

            //Actual saving of the claim to the DB
            //...
        }
    }
}
