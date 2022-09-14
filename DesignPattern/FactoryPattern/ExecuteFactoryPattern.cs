using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPattern
{
    internal class ExecuteFactoryPattern
    {
        public void ExecuteCode()
        {
            var point = PointFactory.NewPolarPoint(1.0, Math.PI / 2);
            Console.WriteLine(point.ToString());

        }
        
    }
}
