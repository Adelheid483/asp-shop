using System.Collections.Generic;

namespace asp_shop.Data.Models
{
    public class Category
    {
        public int CategoryId { set; get; } // set and get means that we can getting datas from this variable and settngs datas in this variable
        public string CategoryName { set; get; }
        public string CategoryDescription { set; get; }
        public List<Car> CarsInCategory { set; get; } // Category can have many Cars, Car can have only one Category
    }
}