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
        /// CategoryID daje zamiast CategoryName
        /// zeby byl to klucz obcy do tabeli z kategoriami
        /// </summary>
        public string CategoryName { get; set; }

        public Product(int id, string name, string description, double price, string categoryName)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.CategoryName = categoryName;
        }
    }
}
