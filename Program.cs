// See https://aka.ms/new-console-template for more information
using ShoppingCartApp;

class Program
{
    static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            var shirt = new ClothingProduct("Shirt", 19.99, ProductCategory.Clothing, "L", "Blue");
            var phone = new ElectronicsProduct("Phone", 699.99, ProductCategory.Electronics, "Brand", "Model");

            var cart = new ShoppingCart(10);
            cart.AddProduct(shirt);
            cart.AddProduct(phone);

            foreach (var product in cart.Products)
            {
                product?.GetInfo();
            }
        }
    }
}

