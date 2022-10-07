using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryObjCuOCP.FactoryObjWithOCP_V2.Interfaces
{
    /// <summary>
    /// Creates an objerct of T type
    /// </summary>
    /// <typeparam name="T">The output type</typeparam>
    internal interface IFactory<T>
    {
        T CreateInstance(Type instanceType);
    }
}
