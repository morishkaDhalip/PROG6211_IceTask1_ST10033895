using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class ElectronicsProduct : Product
    {
        private string brand;
        private string model;

        public string Brand { get => brand; }
        public string Model { get => model; }

        public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model)
            : base(name, price, category)
        {
            this.brand = brand;
            this.model = model;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Brand: {Brand}, Model: {Model}");
        }
    }

}
