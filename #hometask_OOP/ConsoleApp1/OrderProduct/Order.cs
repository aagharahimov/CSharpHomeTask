using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    internal class Order
    {
        private Product[] products;
        public Product[] Produts { get => products; }

        public int Limit { get; set; } = 10;

        public Order()
        {
           products = new Product[0];
        }

        public void AddProduct(Product product)
        {
            if (Limit > products.Length)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;
            }
            else
            {
                Console.WriteLine("sifarsiniz max mehsul sayina catib.");
            }
        }

        public void RemoveProduct(Product product)
        {
            var index = Array.IndexOf(products, product);
            if (index != -1)
            {
                for (int i = index; i < products.Length - 1; i++)
                {
                    products[i] = products[i + 1];
                }

                Array.Resize(ref products, products.Length - 1);
            }

            else
            {
                Console.WriteLine("axtardiginiz mehsul sifarisde yoxdur");
            }
        }

        public void GetDetails()
        {
            foreach (var product in products)
            {
                product.GetDetails();
            }
        }

        public decimal GetTotalAmount()

        {
            decimal sum = 0;

            foreach (var product in products)
            {
                sum += product.Price;
            }
            return sum;
        }
    }
}
