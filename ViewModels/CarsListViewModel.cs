using System.Collections.Generic;
using asp_shop.Data.Models;

namespace asp_shop.ViewModels
{
    public class CarsListViewModel // Model for template
    {
        public IEnumerable<CarModel> GetAllCars { get; set; }
        public string CurrentCategory { get; set; }
    }
}