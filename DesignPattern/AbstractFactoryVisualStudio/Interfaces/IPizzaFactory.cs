using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryVisualStudio.Interfaces
{
    internal interface IPizzaFactory
    {
        IPizza CreatePizza(List<string> ingredients);
    }
}
