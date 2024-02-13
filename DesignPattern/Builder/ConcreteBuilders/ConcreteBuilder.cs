using DesignPattern.Builder.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder.ConcreteBuilders
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }

        public void BuildPartA()
        {
            _product.AddPart("Part A");
        }

        public void BuildPartB()
        {
            _product.AddPart("Part B");
        }

        public void BuildPartC()
        {
            _product.AddPart("Part C");
        }

        public Product GetProduct()
        {
            Product result = _product;
            Reset();
            return result;
        }
    }
}
