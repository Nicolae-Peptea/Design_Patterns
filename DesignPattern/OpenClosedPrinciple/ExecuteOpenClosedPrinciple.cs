using DesignPattern.Specs.OpenClosedPrinciple;
using System;

namespace DesignPattern.OpenClosedPrinciple
{
    public class ExecuteOpenClosedPrinciple
    {
        public void ExecuteCode()
        {
            var apple = new Product("apple", Color.Green, Size.Small);
            var tree = new Product("tree", Color.Green, Size.Large);
            var house = new Product("house", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var productFilter = new ProductFilter();
            var filteredProducts = productFilter.FilterByColor(products, Color.Green);
            Console.WriteLine("Green products (old):");

            foreach (var product in filteredProducts)
            {
                Console.WriteLine($" - {product.Name} is Green");
            }

            Console.WriteLine("Green product (new):");

            var betterFilter = new BetterFilter();
            var filterByGreenColor = new ColorSpecification(Color.Green);

            foreach (var product in betterFilter.Filter(products, filterByGreenColor))
            {
                Console.WriteLine($" - {product.Name} is Green");
            }

            Console.WriteLine("Large blue items:");
            var filterByBlueColor = new ColorSpecification(Color.Blue);
            var filterByLargeSize = new SizeSpecification(Size.Large);
            var andSpecifiaction = new AndSpecification<Product>(filterByLargeSize, filterByBlueColor);

            foreach (var product in betterFilter.Filter(products, andSpecifiaction))
            {
                Console.WriteLine($" - {product.Name} is blue and large");
            }
        }


    }
}
