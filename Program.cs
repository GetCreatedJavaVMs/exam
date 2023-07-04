using RomanClass;
using System;

// Малков Роман 22ИС

namespace RomanMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("Пятерочка", "Москва, ул.Полярная 32к1");

            Product CocaCola = new Product("CocaCola", 12);
            Product Fanta = new Product("Fanta", 10);
            Product Lays = new Product("Lays", 33);

            CocaCola.Show();
            Fanta.Show();
            Lays.Show();

            store.Products.Add(CocaCola);
            store.Products.Add(Fanta);
            store.Products.Add(Lays);

            Console.WriteLine();

            store.Products.Sort();
            store.ShowAll();


            Console.ReadKey();
        }
    }
}
