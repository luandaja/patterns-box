using System;
using Adapter.Models.Requests;
using Adapter.ThirdPartyAPI;
using AutoMapper;

namespace Adapter.Adapters
{
    public class HipaaAdapter : IHipaaAdapter
    {
        private readonly IMapper _mapper;
        private readonly HipaaClient _hipaaClient;
        public HipaaAdapter(IMapper mapper)
        {
            _mapper = mapper;
            _hipaaClient = new HipaaClient();
        }
        public string GetHipaaResponse(ClaimRequest request)
        {
            var hipaaRequest = _mapper.Map<HipaaRequest>(request);
            return _hipaaClient.GetHipaaResponse(hipaaRequest);
        }
    }
}
