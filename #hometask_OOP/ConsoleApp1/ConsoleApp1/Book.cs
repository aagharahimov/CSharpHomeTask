using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; private set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = false;
        }

        public void Borrow()
        {
            if (!IsBorrowed)
            {
                IsBorrowed = true;
                Console.WriteLine($"{Title} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{Title} is already borrowed.");
            }
        }

        public void Return()
        {
            if (IsBorrowed)
            {
                IsBorrowed = false;
                Console.WriteLine($"{Title} has been returned.");
            }
            else
            {
                Console.WriteLine($"{Title} was not borrowed.");
            }
        }

        public void GetDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Borrowed: {IsBorrowed}");
        }
    }
}
