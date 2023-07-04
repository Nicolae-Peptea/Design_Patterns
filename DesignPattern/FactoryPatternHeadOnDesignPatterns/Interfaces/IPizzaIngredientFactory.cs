using DesignPattern.FactoryPatternHeadOnDesignPatterns.Abstracts.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPatternHeadOnDesignPatterns.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public List<Veggie> CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clams CreateClam();
    }
}
