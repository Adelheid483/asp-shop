using asp_shop.Data.Interfaces;
using asp_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace asp_shop.Controllers
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

        public ViewResult CarsList()
        {
            // ViewBag.Category = "Some new category"; - better do not use: another possibility to pass date into template 

            CarsListViewModel obj = new CarsListViewModel();
            obj.GetAllCars = _allCars.GetCars;
            obj.CurrentCategory = "Automobiles";
            
            return View(obj); // return html-page
        }
    }
}