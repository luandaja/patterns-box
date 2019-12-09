using Adapter.Models.Requests;

namespace Adapter.ThirdPartyAPI
{
    public class HipaaClient
    {
        public string GetHipaaResponse(HipaaRequest request)
        {
            //some external call to Hipaa API
            return "Hipaa response";
        }
    }
}
