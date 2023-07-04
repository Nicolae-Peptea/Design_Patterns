using DesignPattern.FactoryPatternHeadOnDesignPatterns.Abstracts.Ingredients;
using DesignPattern.FactoryPatternHeadOnDesignPatterns.Concretes.Ingredients.CheeseTypes;
using DesignPattern.FactoryPatternHeadOnDesignPatterns.Concretes.Ingredients.ClamsType;
using DesignPattern.FactoryPatternHeadOnDesignPatterns.Concretes.Ingredients.DoughType;
using DesignPattern.FactoryPatternHeadOnDesignPatterns.Concretes.Ingredients.PepperoniType;
using DesignPattern.FactoryPatternHeadOnDesignPatterns.Concretes.Ingredients.SauceTypes;
using DesignPattern.FactoryPatternHeadOnDesignPatterns.Concretes.Ingredients.VeggieType;
using DesignPattern.FactoryPatternHeadOnDesignPatterns.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPattern.FactoryPatternHeadOnDesignPatterns.Factories
{
    public class NyPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
           return new ReggianoCheese();
        }

        public Clams CreateClam()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public List<Veggie> CreateVeggies()
        {
            List<Veggie> veggies = new List<Veggie>
            {
                new Garlic(),
                new Onion()
            };

            return veggies;
        }
    }
}
