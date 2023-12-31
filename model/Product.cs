using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buoi_toi.model
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
        public string Description { get; set; }

        public Category Category { get; set; }

        public Product(int id, string name, string description, int price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }
        public Product()
        {

        }

    }
}