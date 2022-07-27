using DesignPattern.OpenClosedPrinciple.Interfaces;
using System.Collections.Generic;

namespace DesignPattern.OpenClosedPrinciple
{
    internal class BetterFilterForProducts : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> input, ISpecification<Product> specification)
        {
            foreach (var item in input)
            {
                if (specification.IsSatisfied(item))
                {
                    yield return item;
                }
            }
        }
    }
}
