using System.Collections.Generic;
using asp_shop.Data.Models;

namespace asp_shop.Data.Interfaces
{
    public interface ICars
    {
        IEnumerable<CarModel> GetCars { get; }
        IEnumerable<CarModel> GetFavCars { get; set; }
        CarModel GetCarObject(int carId);
    }
}
