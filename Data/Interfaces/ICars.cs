using System.Collections.Generic;
using asp_shop.Data.Models;

namespace asp_shop.Data.Interfaces
{
    public interface ICars
    {
        IEnumerable<Car> GetCars { get; }
        IEnumerable<Car> GetFavCars { get; set; }
        Car GetCarObject(int carId);
    }
}
