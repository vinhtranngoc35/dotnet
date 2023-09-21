using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buoi_toi.model;

namespace buoi_toi.service
{
    public class ProductService
    {
        public static ArrayList Products = new();


        public static int IdCurrent = 0;

        public static void AddProduct(Product product)
        {
            IdCurrent++;
            product.Id = IdCurrent;
            Products.Add(product);
        }
        public static void RemoveProduct(int id)
        {
            foreach (Product product in Products)
            {
                if (product.Id == id)
                {
                    Products.Remove(product);
                    break;
                }
            }
        }
        //[{id: 1, name: "Product"}, {id: 2, name: "Product2"}]
        //{id:2, name: "Cafe"}
        //[{id: 1, name: "Product"}, {id: 2, name: "Cafe"}]
        public static void EditProduct(Product productEdit)
        {
            foreach (Product product in Products)
            {
                if (product.Id == productEdit.Id)
                {
                    product.Name = productEdit.Name;
                    product.Price = productEdit.Price;
                    product.Description = productEdit.Description;
                    break;
                }
            }
        }


    }
}