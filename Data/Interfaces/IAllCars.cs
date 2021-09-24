using System.Collections.Generic;
using asp_shop.Data.Models;

namespace asp_shop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> getCars { get; }
        IEnumerable<Car> getFavCars { get; set; }
        Car getCarObject(int carID);
    }
}
