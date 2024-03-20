using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ShoppingCartApp
{
    public class ClothingProduct : Product
    {
        private string size;
        private string color;

        public string Size { get => size; }
        public string Color { get => color; }

        public ClothingProduct(string name, double price, ProductCategory category, string size, string color)
            : base(name, price, category)
        {
            this.size = size;
            this.color = color;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Size: {Size}, Color: {Color}");
        }
    }

}
