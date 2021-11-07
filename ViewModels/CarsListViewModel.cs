using System.Collections.Generic;
using asp_shop.Data.Models;

namespace asp_shop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<CarModel> GetAllCars { get; set; }
        public string CurrentCategory { get; set; }
    }
}