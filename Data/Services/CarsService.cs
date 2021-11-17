using System.Collections.Generic;
using System.Linq;
using asp_shop.Data.Interfaces;
using asp_shop.Data.Models;

namespace asp_shop.Data.Services
{
    public class CarsService : ICars
    {
        private readonly ICategories _categoriesCars = new CategoriesService();
        
        public IEnumerable<CarModel> GetCars =>
            new List<CarModel>
            {
                new CarModel
                {
                    Name = "name1",
                    ShortDescription = "shortDescription",
                    LongDescription = "longDescription",
                    Img = "img//",
                    Price = 14000,
                    IsFavorite = true,
                    Available = true,
                    CategoryModel = _categoriesCars.AllCategories.First()
                },
                new CarModel
                {
                    Name = "name2",
                    ShortDescription = "shortDescription",
                    LongDescription = "longDescription",
                    Img = "img//",
                    Price = 8000,
                    IsFavorite = false,
                    Available = true,
                    CategoryModel = _categoriesCars.AllCategories.Last()
                }
            };

        public IEnumerable<CarModel> GetFavCars { get; set; }
        
        public CarModel GetCarObject(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}