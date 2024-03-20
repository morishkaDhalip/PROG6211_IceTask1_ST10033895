using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class ShoppingCart
    {
        private Product[] products;
        private int itemCount;

        public Product[] Products { get => products; }
        public int ItemCount { get => itemCount; }

        public ShoppingCart(int capacity)
        {
            products = new Product[capacity];
            itemCount = 0;
        }

        public void AddProduct(Product product)
        {
            if (itemCount < products.Length)
            {
                products[itemCount] = product;
                itemCount++;
            }
            else
            {
                Console.WriteLine("The shopping cart is full.");
            }
        }

        public void RemoveProduct(Product product)
        {
            int index = Array.IndexOf(products, product);
            if (index != -1)
            {
                for (int i = index; i < itemCount - 1; i++)
                {
                    products[i] = products[i + 1];
                }
                itemCount--;
            }
            else
            {
                Console.WriteLine("The product is not in the shopping cart.");
            }
        }
    }
}
