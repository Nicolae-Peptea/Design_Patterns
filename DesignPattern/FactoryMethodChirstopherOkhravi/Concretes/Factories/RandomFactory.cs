using DesignPattern.FactoryMethodChirstopherOkhravi.Abstracts.Animals;
using DesignPattern.FactoryMethodChirstopherOkhravi.Abstracts.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethodChirstopherOkhravi.Concretes.Factories
{
    public class RandomFactory : IAnimalFactory
    {
        public IAnimal Create()
        {
            throw new NotImplementedException();
        }
    }
}
