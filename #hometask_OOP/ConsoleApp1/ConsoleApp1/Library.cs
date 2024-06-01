using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"{book.Title} has been added to the library.");
        }

        public void RemoveBook(Book book)
        {
            if (books.Remove(book))
            {
                Console.WriteLine($"{book.Title} has been removed from the library.");
            }
            else
            {
                Console.WriteLine($"{book.Title} not found in the library.");
            }
        }

        public void GetBooks()
        {
            foreach (var book in books)
            {
                book.GetDetails();
            }
        }

        public Book FindBookByISBN(string isbn)
        {
            return books.Find(book => book.ISBN == isbn);
        }
    }
}

