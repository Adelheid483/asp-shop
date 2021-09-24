using System.Collections.Generic;
using asp_shop.Data.Interfaces;
using asp_shop.Data.Models;

namespace asp_shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        // here will be realizing functions from Interfaces
        public IEnumerable<Category> AllCategories 
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Electrocar", description = "Modern car"},
                    new Category {categoryName = "Classic car", description = "Old type car"},
                };
            }
        }
    }
}