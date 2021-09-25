using asp_shop.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace asp_shop.Data.Controllers
{
    public class CarsController : Controller
    {
        // Controllers - functions which returns View result

        private readonly ICars _allCars;
        private readonly ICategories _allCategories;
        
        // constructor
        public CarsController(ICars allCars, ICategories allCategories)
        {
            _allCars = allCars;
            _allCategories = allCategories;
        }

        public ViewResult ReturnCarsList()
        {
            var cars = _allCars.GetCars; // pass data for view
            return View(cars); // return html-page
        }
    }
}