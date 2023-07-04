using DesignPattern.FactoryPatternHeadOnDesignPatterns.Concretes;
using DesignPattern.FactoryPatternHeadOnDesignPatterns.Factories;
using DesignPattern.FactoryPatternHeadOnDesignPatterns.Interfaces;

namespace DesignPattern.FactoryPatternHeadOnDesignPatterns
{
    public class NyPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NyPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "New York Style Cheese Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "New York Style clam PIzza";
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
