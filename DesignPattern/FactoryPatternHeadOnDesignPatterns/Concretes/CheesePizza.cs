using DesignPattern.FactoryPatternHeadOnDesignPatterns.Factories;
using DesignPattern.FactoryPatternHeadOnDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPatternHeadOnDesignPatterns.Concretes
{
    internal class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
        }
    }
}
