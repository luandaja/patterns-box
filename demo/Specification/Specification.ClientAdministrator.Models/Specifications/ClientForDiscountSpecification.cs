using System;
using System.Linq.Expressions;

namespace Specification.ClientAdministrator.Models.Specifications
{
    public class ClientForDiscountSpecification : IClientSpecification
    {
        public Expression<Func<Client, bool>> IsSatisfiedBy
            => c => c.JoinDate < DateTime.Now.AddDays(-30) && c.Age > 25;
    }
}
