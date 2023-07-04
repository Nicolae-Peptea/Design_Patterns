using DesignPattern.AbstractFactoryVisualStudio.Interfaces;
using DesignPattern.FactoryPatternHeadOnDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPatternHeadOnDesignPatterns.Concretes
{
    public class ClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _ingredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Clam = _ingredientFactory.CreateClam();
        }
    }
}
