using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections_PhoneBook
{
    internal class PhoneBook
    {
        public Dictionary<string,string> Contacts {  get; set; }

        public PhoneBook()
        {
            Contacts = new Dictionary<string, string>();
        }

        public void AddContact(string name, string phoneNumber)
        {
            Contacts[name] = phoneNumber;
        }

        public void RemoveContact(string name)
        {
           Contacts.Remove(name);
                
        }

        public void GetAllContacts() 
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine($"{contact.Key}, {contact.Value}");
            }
        }

        public string FindContactByName(string Name)
        {
            foreach (var contact in Contacts)
            {
                if (contact.Key == Name)
                    return contact.Value;

            }
            return null;
        }


    }
}
