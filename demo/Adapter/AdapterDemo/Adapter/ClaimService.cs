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

        public string ProcessClaim(ClaimRequest request)
        {
            var response = _hipaaAdapter.GetHipaaResponse(request);

            return response;
        }
    }
}
