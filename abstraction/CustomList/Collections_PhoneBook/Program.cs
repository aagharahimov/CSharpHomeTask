using Collections_PhoneBook;
using System;



public static class Program
{
    public static void Main(string[] args)
    {
        PhoneBook phoneBook = new PhoneBook();
        phoneBook.AddContact("agasi", "0515900036");
        phoneBook.AddContact("agarahimov", "0555555555");

        Console.WriteLine(phoneBook.FindContactByName("agasi"));
        phoneBook.RemoveContact("agasi");
        phoneBook.GetAllContacts();
    }
}