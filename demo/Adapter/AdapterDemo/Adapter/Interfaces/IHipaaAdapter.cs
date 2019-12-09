using Adapter.Models.Requests;

namespace Adapter
{
    public interface IHipaaAdapter
    {
        string GetHipaaResponse(ClaimRequest request);
    }
}
