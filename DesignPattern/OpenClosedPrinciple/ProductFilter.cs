using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.OpenClosedPrinciple
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var item in products)
            {
                if (item.Size == size)
                {
                    yield return item;
                }
            }
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var item in products)
            {
                if (item.Color == color)
                {
                    yield return item;
                }
            }
        }

        public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var item in products)
            {
                if (item.Color == color && item.Size == size)
                {
                    yield return item;
                }
            }
        }
    }
}
