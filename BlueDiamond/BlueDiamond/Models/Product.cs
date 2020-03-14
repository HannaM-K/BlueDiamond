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
        /// <summary>
        /// CategoryID daje zamiast categoryNames
        /// zeby byl to klucz obcy do tabeli z kategoriami (przyszłość)
        /// </summary>
        public List<string> CategoryNames { get; set; }

        public Product(int id, string name, string description, double price, List<string> categoryNames)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.CategoryNames = categoryNames;
        }
    }
}
