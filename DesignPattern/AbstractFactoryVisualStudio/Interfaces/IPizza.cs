using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactoryVisualStudio.Interfaces
{
    internal interface IPizza
    {
        IList<string> Toppings { get; }
        string Seasonings { get; set; }
        string SauceType { get; set; }
        public void Bake();
        public void Cut();
        public void Box();
    }
}
