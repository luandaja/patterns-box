using System;
using System.Linq.Expressions;

namespace Specification.ClientAdministrator.Models.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> IsSatisfiedBy { get; }
    }
}
