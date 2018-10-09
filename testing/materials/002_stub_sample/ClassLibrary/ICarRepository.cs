using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public interface ICarRepository
    {
        IEnumerable<Car> LoadCars(CarType type, DateTime year);
    }
}
