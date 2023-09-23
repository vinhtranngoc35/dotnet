using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buoi_toi.model;

namespace buoi_toi.service
{
    public class CategoryService
    {
        private static readonly List<Category> _categories = new();


        public static List<Category> GetCategories()
        {
            return _categories;
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetCategory(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);

            // foreach(var category in _categories){
            //     if(category.Id == id){
            //         return category;
            //     }
            // }
            // return null;
        }
    }
}