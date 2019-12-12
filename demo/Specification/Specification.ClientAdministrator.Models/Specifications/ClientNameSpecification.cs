using Specification.ClientAdministrator.Models;
using System;
using System.Linq.Expressions;

namespace Specification.ClientAdministrator.Models.Specifications
{
    public class ClientNameSpecification : IClientSpecification
    {
        private readonly string _name;

        public ClientNameSpecification(string name)
        {
            _name = name;
        }

        public Expression<Func<Client, bool>> IsSatisfiedBy
            => c => c.Name.Contains(_name) || c.LastName.Contains(_name);        
    }
}
