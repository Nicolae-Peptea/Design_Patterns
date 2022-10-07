using DesignPattern.FactoryObjCuOCP;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryObjCuOCP_V3.Interfaces
{
    internal interface IFactory<T>
    {
        T Create();
    }
}
