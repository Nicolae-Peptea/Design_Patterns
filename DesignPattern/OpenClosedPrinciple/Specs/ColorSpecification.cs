using DesignPattern.OpenClosedPrinciple;
using DesignPattern.OpenClosedPrinciple.Interfaces;

namespace DesignPattern.Specs.OpenClosedPrinciple
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color _color;

        public ColorSpecification(Color color)
        {
            _color = color;
        }

        public bool IsSatisfied(Product entity)
        {
            return entity.Color == _color;
        }
    }
}
