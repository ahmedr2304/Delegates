using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class BookManagment
    {
        public delegate bool Predicate(Book book);

        
        public static int CountBooks(List<Book> books, Predicate predicate) 
        {
            int count = 0;
            foreach (Book book in books) 
            {
                if (predicate(book)) 
                {
                    count++;
                }
            }
            return count;

        }

    }
    public class Book
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

        public Book(string title, decimal price)
        {
            this.Title = title;
            this.Price = price;

        }

    }
}