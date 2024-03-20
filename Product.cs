﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class Product
    {
        private string name;
        private double price;
        private ProductCategory category;

        public string Name { get => name; }
        public double Price { get => price; }
        public ProductCategory Category { get => category; }

        public Product(string name, double price, ProductCategory category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Category: {Category}");
        }
    }

}
