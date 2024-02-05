using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Prototype
{
    public class BookShop : IClone<BookShop>
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();

        public void LoadData()
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Book book = new Book();
                int randomId = random.Next(1, 100);
                book.Id =randomId;
                book.Name = $"Book {randomId}";
                Books.Add(book);
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

           stringBuilder.AppendLine($"Book store name: {Name} has the follwoing books");
            foreach (var item in Books)
            {
                stringBuilder.AppendLine(item.ToString());
            };

            return stringBuilder.ToString();
        }

        public BookShop Clone()
        {
            BookShop clonedBookShop = new BookShop();

            List<Book> clonedBookList = new List<Book>();
            Books.ForEach(book => clonedBookList.Add(book));  
            
            clonedBookShop.Name = Name;
            clonedBookShop.Books = clonedBookList;

            return clonedBookShop;
        }
    }
}
