using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Exercises.Factory
{
    internal class PersonFactory : IPersonFactory
    {
        private int id = 0;

        public IPerson CreatePerson(string name)
        {
            return new Person
            {
                Id = id++,
                Name = name
            };
        }
    }
}
