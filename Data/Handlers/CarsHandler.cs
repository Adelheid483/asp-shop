using System.Collections.Generic;
using System.Linq;
using asp_shop.Data.Interfaces;
using asp_shop.Data.Models;

namespace asp_shop.Data.Handlers
{
    public class CarsHandlers : ICars
    {
        private readonly ICategories _categoriesCars = new CategoriesHandler();
        
        public IEnumerable<Car> GetCars =>
            new List<Car>
            {
                new Car
                {
                    Name = "name1",
                    ShortDescription = "shortDescription",
                    LongDescription = "longDescription",
                    Img = "img//",
                    Price = 14000,
                    IsFavorite = true,
                    Available = true,
                    Category = _categoriesCars.AllCategories.First()
                },
                new Car
                {
                    Name = "name2",
                    ShortDescription = "shortDescription",
                    LongDescription = "longDescription",
                    Img = "img//",
                    Price = 8000,
                    IsFavorite = false,
                    Available = true,
                    Category = _categoriesCars.AllCategories.Last()
                }
            };

        public IEnumerable<Car> GetFavCars { get; set; }
        
        public Car GetCarObject(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}