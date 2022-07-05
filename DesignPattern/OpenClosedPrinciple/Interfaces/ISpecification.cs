namespace DesignPattern.OpenClosedPrinciple.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T entity);
    }
}
