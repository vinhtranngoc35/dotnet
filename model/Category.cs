using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buoi_toi.model
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}