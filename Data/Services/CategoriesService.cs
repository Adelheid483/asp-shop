using System.Collections.Generic;
using asp_shop.Data.Interfaces;
using asp_shop.Data.Models;

namespace asp_shop.Data.Services
{
    public class CategoriesService : ICategories
    {
        // realizing interface for work with Categories
        public IEnumerable<CategoryModel> AllCategories =>
            new List<CategoryModel>
            {
                new CategoryModel {CategoryName = "Electrocar", CategoryDescription = "Modern car"},
                new CategoryModel {CategoryName = "Classic car", CategoryDescription = "Old type car"},
            };
    }
}