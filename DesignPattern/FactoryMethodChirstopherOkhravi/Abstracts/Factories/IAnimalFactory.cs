using DesignPattern.FactoryMethodChirstopherOkhravi.Abstracts.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethodChirstopherOkhravi.Abstracts.Factories
{
    public interface IAnimalFactory
    {
        IAnimal Create();
    }
}
