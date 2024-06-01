using LibraryApp;
using System;

namespace LibraryApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("1984", "George Orwell", "123");
            Book book2 = new Book("kitab", "Elxan Elatli", "345");
            Book book3 = new Book("kitab3", "chingiz aytmatov", "567");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            library.GetBooks();

            book1.Borrow();
            library.GetBooks();

            book1.Return();
            library.GetBooks();

            library.RemoveBook(book2);
            library.GetBooks();

            Book foundBook = library.FindBookByISBN("1234567892");
            if (foundBook != null)
            {
                Console.WriteLine("Book found:");
                foundBook.GetDetails();
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}
