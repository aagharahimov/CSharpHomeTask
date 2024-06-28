using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceProgram
{
    internal class Invoice
    {
        private int Account { get; set; }
        private string Customer { get; set; }
        private string Provider { get; set; }
        public string Article { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;

        }

        public void CostCalculation(bool needEdv)
        {
            if (needEdv == true)
            {
                Price = Math.Round(Price * Quantity * 1.18, 2);
            }
            else
            {
                Price = Price * Quantity;
            }

            Console.WriteLine($" Article:{Article}, Quantity:{Quantity}, Price:{Price},");

        }


    }
}
