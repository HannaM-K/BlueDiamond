using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<Category> Categories { get; set; }

        public Product() { }
        public Product(string name, string description, double price, List<Category> categories)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Categories = categories;
        }
    }
}
