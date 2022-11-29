using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryWithOCP.Interfaces
{
    internal interface IFactory<T>
    {
        T Create();
    }
}
