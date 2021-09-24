using System.Collections.Generic;
using asp_shop.Data.Interfaces;
using asp_shop.Data.Models;

namespace asp_shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        public IEnumerable<Car> getCars { get; set; }
        public IEnumerable<Car> getFavCars { get; set; }
        public Car getCarObject(int carID)
        {
            throw new System.NotImplementedException();
        }
    }
}