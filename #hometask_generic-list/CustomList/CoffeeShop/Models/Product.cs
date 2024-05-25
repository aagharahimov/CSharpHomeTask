﻿namespace CoffeeShop.Models
{
    public abstract class Product
    {
        protected Product(string name, int count, decimal price)
        {
            Name = name;
            Count = count;
            Price = price;
        }

        public string Name { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
