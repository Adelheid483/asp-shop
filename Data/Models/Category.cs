using System.Collections.Generic;

namespace asp_shop.Data.Models
{
    public class Category
    {
        // variables
        public int id { set; get; } // set and get means that we can getting datas from this variable and settngs datas in this variable
        public string categoryName { set; get; }
        public string description { set; get; }
        public List<Car> cars { set; get; } // Category can have many Cars, Car can have only one Category
    }
}