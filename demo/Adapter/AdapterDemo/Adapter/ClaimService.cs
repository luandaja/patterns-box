using Adapter.Models.Requests;

namespace Adapter
{
    public class ClaimService
    {
        private readonly IHipaaAdapter _hipaaAdapter;
        public ClaimService(IHipaaAdapter hipaaAdapter)
        {
            _hipaaAdapter = hipaaAdapter;
        }

        public int AddClaim(ClaimRequest request)
        {
            _hipaaAdapter.GetHipaaResponse(request);

            //Actual saving of the claim to the DB
            //...

            return 1;
        }
    }
}
