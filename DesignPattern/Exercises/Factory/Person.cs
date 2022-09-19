using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Exercises.Factory
{
    internal class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
