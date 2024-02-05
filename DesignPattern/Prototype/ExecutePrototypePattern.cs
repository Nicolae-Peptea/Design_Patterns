using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    public static class ExecutePrototypePattern
    {
        public static void Execute()
        {
            BookShop nuveleBookShop = new BookShop();
            nuveleBookShop.Name = "Nuvele";
            nuveleBookShop.LoadData();
            Console.WriteLine(nuveleBookShop.ToString());

            BookShop carturestiBookShop = nuveleBookShop.Clone();

            nuveleBookShop.Books.RemoveAt(1);
            Console.WriteLine(nuveleBookShop.ToString());

            carturestiBookShop.Name = "Carturesti";
            Console.WriteLine(carturestiBookShop.ToString());
            carturestiBookShop.LoadData();
        }
    }
}
