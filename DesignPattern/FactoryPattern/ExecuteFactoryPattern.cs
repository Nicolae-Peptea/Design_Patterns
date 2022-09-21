using System;

namespace DesignPattern.FactoryPattern
{
    internal class ExecuteFactoryPattern
    {
        public void ExecuteCode()
        {
            var point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
            Console.WriteLine(point.ToString());

        }

    }
}
