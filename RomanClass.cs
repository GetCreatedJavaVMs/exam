using System;
using System.Collections.Generic;
// Малков Роман 22ИС

namespace RomanClass
{
    public class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }        
        public List<Product> Products = new List<Product>();
        
        // constructor
        public Store(string Name, string Address)
        {
            this.Name    = Name;
            this.Address = Address;
        }

        // show store info method
        public void ShowAll()
        {
            Console.WriteLine($"В магазине \"{this.Name}\" по адрессу {this.Address} есть следующие товары: ");
            foreach (Product product in this.Products)
            {
                Console.WriteLine($"{product.Name} ({product.Count}) шт.");
            }
        }
    }

    
    public class Product : IComparable<Product>{
        public string Name { get; set; }
        public int Count { get; set; }

        // constructor
        public Product(string Name, int Count)
        {
            this.Name  = Name;
            this.Count = Count;
        }

        // show method for product
        public void Show()
        {
            Console.WriteLine($"Товар: \"{this.Name}\" ({this.Count} шт.)");
        }

        // method for compare other product
        public int CompareTo(Product otherProduct)
        {
            if(this.Count < otherProduct.Count) return -1;       
            else if (this.Count > otherProduct.Count) return 1;
            else return 0;
        }

    }

}
