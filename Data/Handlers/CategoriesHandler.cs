using System.Collections.Generic;
using asp_shop.Data.Interfaces;
using asp_shop.Data.Models;

namespace asp_shop.Data.Handlers
{
    public class CategoriesHandler : ICategories
    {
        // here will be realizing functions from Interfaces
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category {CategoryName = "Electrocar", CategoryDescription = "Modern car"},
                new Category {CategoryName = "Classic car", CategoryDescription = "Old type car"},
            };
    }
}