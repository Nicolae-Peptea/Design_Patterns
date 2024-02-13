using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder.Products
{
    public class Product
    {
        private List<string> _parts = new List<string>();

        public void AddPart(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string part in _parts) 
            {
                stringBuilder.AppendLine(part);
            }

            return $"Product parts: {stringBuilder}";
        }
    }
}
