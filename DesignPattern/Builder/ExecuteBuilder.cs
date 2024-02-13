using DesignPattern.Builder.ConcreteBuilders;
using DesignPattern.Builder.Directors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    public static class ExecuteBuilder
    {
        public static void Execute()
        {
            var builder = new ConcreteBuilder();
            var director = new Director(builder);

            Console.WriteLine("Standard basic product");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.Write(builder.GetProduct().ListParts());
        }
    }
}
