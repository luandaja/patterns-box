using Specification.ClientAdministrator.DataSource;
using Specification.ClientAdministrator.Models;
using Specification.ClientAdministrator.Models.Specifications;
using System.Collections.Generic;
using System.Linq;

namespace Specification.ClientAdministrator.Repository
{
    public class ClientRepository
    {
        private readonly List<Client> _data;

        public ClientRepository()
        {
            _data = new ClientDataSource().GetClientsData();
        }

        public List<Client> GetClientBy(IClientSpecification clientSpecification)
        {
            return _data.Where(clientSpecification.IsSatisfiedBy.Compile()).ToList();
        }
    }
}
