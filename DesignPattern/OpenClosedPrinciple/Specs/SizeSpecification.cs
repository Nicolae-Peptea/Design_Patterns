using DesignPattern.OpenClosedPrinciple;
using DesignPattern.OpenClosedPrinciple.Interfaces;

namespace DesignPattern.Specs.OpenClosedPrinciple
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size _size;

        public SizeSpecification(Size size)
        {
            _size = size;
        }

        public bool IsSatisfied(Product entity)
        {
            return entity.Size == _size;
        }
    }
}
