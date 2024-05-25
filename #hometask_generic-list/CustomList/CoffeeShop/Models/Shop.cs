using CoffeeShop.Abstract;

namespace CoffeeShop.Models
{
    public class Shop<T> : IDrinkShop<T> where T : Product
    {
        private Product[] products;
        private int capacity;
        private int count;

        public Shop()
        {
            TotalIncome = 0;
            products = new Product[4];
            capacity = products.Length;
        }

        public double TotalIncome { get; private set; }

        public void AddProduct(T product)
        {
            if (ProductExists(product.Name))
            {
                Console.WriteLine("Product with the same name cannot be added");
                return;
            }

            if (count == capacity)
            {
                Array.Resize(ref products, capacity == 0 ? 4 : products.Length * 2);
                capacity = products.Length;
            }

            products[count] = product;
            count++;
        }

        public void SellProduct(string name, int quantity)
        {
            if (!ProductExists(name))
            {
                Console.WriteLine("Product not found!");
                return;
            }

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i]?.Name == name)
                {
                    if (products[i].Count >= quantity)
                    {
                        products[i].Count -= quantity;
                        TotalIncome += (double)(quantity * products[i].Price);

                        if (products[i].Count == 0)
                        {
                            products[i] = products[count - 1];
                            products[count - 1] = null;
                            count--;
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Not enough stock available");
                        return;
                    }
                }
            }
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Available products:");
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    break;
                }
                Console.WriteLine($"Name: {products[i].Name}, Price: {products[i].Price}, Count: {products[i].Count}, Type: {products[i]}");
            }
        }

        public void ShowIncome()
        {
            Console.WriteLine($"Daily total income: {TotalIncome}");
        }

        private bool ProductExists(string productName)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i]?.Name == productName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
