using System;
using System.Collections.Generic;

namespace appTest
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public Location Location { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        public Product()
        {
            ID = 0;
            Name = "Default";
            Category = null;
            Location = null;
            Price = 0;
            Stock = 0;
        }

        public Product(int iD, string name, Category category, Location location, int price, int stock)
        {
            ID = iD;
            Name = name;
            Category = category;
            Location = location;
            Price = price;
            Stock = stock;
        }


        public void AddProductToDB()
        {
            Console.WriteLine("test");
        }


        List<Product> cart = new List<Product>
        {

        };

    }
}
