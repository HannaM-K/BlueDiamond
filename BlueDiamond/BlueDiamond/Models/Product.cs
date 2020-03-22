using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [NotMapped]
        public List<Category> Categories { get; set; }

        public Product() { }
        public Product(string name, string description, double price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
    }
}
