using System;
using System.Linq.Expressions;

namespace Specification.ClientAdministrator.Models.Specifications
{
    public class ClientAgeSpecification : IClientSpecification
    {
        private readonly int _age;

        public ClientAgeSpecification(int age)
        {
            _age = age;
        }

        public Expression<Func<Client, bool>> IsSatisfiedBy
            => c => c.Age == _age;
    }
}
