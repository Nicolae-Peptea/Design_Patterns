using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Exercises.Factory
{
    public interface IPersonFactory
    {
        IPerson CreatePerson(string name);
    }
}
