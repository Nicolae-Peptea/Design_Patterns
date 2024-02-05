using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    public interface IClone<T>
    {
        T Clone();
    }
}
