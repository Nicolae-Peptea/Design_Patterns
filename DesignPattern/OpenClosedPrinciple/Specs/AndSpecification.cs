using DesignPattern.OpenClosedPrinciple.Interfaces;

namespace DesignPattern.Specs.OpenClosedPrinciple
{
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> _first;
        private ISpecification<T> _second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            _first = first;
            _second = second;
        }

        public bool IsSatisfied(T entity)
        {
            return _first.IsSatisfied(entity) && _second.IsSatisfied(entity);
        }
    }
}
