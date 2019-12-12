using System;
using System.Linq.Expressions;

namespace Specification.ClientAdministrator.Models.Specifications
{
    public class ClientMinAgeSpecification : IClientSpecification
    {
        private readonly int _minAge;

        public ClientMinAgeSpecification(int? minAge = null)
        {
            _minAge = minAge.HasValue ? minAge.Value : 25;
        }

        public Expression<Func<Client, bool>> IsSatisfiedBy 
            => c => c.Age < _minAge;
    }
}
