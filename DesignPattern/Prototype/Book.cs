using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
           return $"Book Id: {Id} name: {Name}";
        }
    }
}
