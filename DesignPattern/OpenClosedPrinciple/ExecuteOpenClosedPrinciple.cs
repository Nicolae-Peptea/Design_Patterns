using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OpenClosedPrinciple
{
    public class ExecuteOpenClosedPrinciple
    {
        public void ExecuteCode()
        {
            var apple = new Product("apple", Color.Green, Size.Small);
            var tree = new Product("tree", Color.Green, Size.Large);
            var house = new Product("tree", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var productFilter = new ProductFilter();
            var filteredProducts = productFilter.FilterByColor(products, Color.Green);
            Console.WriteLine("Green products (old):");

            foreach (var product in filteredProducts)
            {
                Console.WriteLine($" - {product.Name} is Green");
            }

        }
        

    }
}
