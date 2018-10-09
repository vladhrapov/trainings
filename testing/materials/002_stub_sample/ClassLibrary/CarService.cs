using System;
using System.Linq;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class CarService
    {
        private readonly ICarRepository carRepository;

        public CarService(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public IEnumerable<Car> GetCarsByTypeAndYear(CarType type, DateTime year)
        {
            try
            {
                var cars = carRepository.LoadCars(type, year);

                if(cars.Any())
                {
                    return cars;                    
                }
                else
                {
                    return new List<Car>();
                }
            }
            catch (Exception ex)
            {
                return new List<Car>();
            }          
        }
    }
}
