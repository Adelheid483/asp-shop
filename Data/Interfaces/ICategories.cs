using System.Collections.Generic;
using asp_shop.Data.Models;

namespace asp_shop.Data.Interfaces
{
    public interface ICategories 
    {
        // put function here, which can get datas from model
        // getting all categories from Category Model in project
        IEnumerable<Category> AllCategories { get; }
    }
}