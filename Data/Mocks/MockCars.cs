using System.Collections.Generic;
using System.Linq;
using asp_shop.Data.Interfaces;
using asp_shop.Data.Models;

namespace asp_shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> getCars =>
            new List<Car>
            {
                new Car
                {
                    name = "name1",
                    shortDescription = "shortDescription",
                    longDescription = "longDescription",
                    img = "img//",
                    price = 14000,
                    isFavorite = true,
                    available = true,
                    Category = _categoryCars.AllCategories.First()
                },
                new Car
                {
                    name = "name2",
                    shortDescription = "shortDescription",
                    longDescription = "longDescription",
                    img = "img//",
                    price = 8000,
                    isFavorite = false,
                    available = true,
                    Category = _categoryCars.AllCategories.Last()
                }
            };

        public IEnumerable<Car> getFavCars { get; set; }
        public Car getCarObject(int carID)
        {
            throw new System.NotImplementedException();
        }
    }
}