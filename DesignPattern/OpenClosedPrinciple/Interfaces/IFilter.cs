using System.Collections.Generic;

namespace DesignPattern.OpenClosedPrinciple.Interfaces
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> input, ISpecification<T> specification);
    }
}
