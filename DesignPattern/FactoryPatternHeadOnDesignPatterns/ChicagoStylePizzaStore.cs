using DesignPattern.FactoryPatternHeadOnDesignPatterns.Concretes;

namespace DesignPattern.FactoryPatternHeadOnDesignPatterns
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            throw new System.NotImplementedException();
        }
    }
}
