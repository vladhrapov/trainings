using System;
using System.Collections.Generic;
using System.Linq;
using NUnit;
using NUnit.Framework;
using ClassLibrary;

namespace Tests {
    public class CarRepositorySuccessMock : ICarRepository
    {
        public IEnumerable<Car> LoadCars(CarType type, DateTime year)
        {
            return new List<Car> {
                new Car {
                    Brand = "Ferrari",
                    Engine = "V8",
                    Price = 2435.5,
                    Type = CarType.Coupe
                }
            };
        }
    }

    public class CarRepositorySuccessEmptyMock : ICarRepository
    {
        public IEnumerable<Car> LoadCars(CarType type, DateTime year)
        {
            return null;
        }
    }

    public class CarRepositoryExceptionMock : ICarRepository {
        public IEnumerable<Car> LoadCars (CarType type, DateTime year) {
            throw new Exception ("Bad error");
        }
    }

    [TestFixture]
    public class CarServiceTest {
        private CarService sut;
        private ICarRepository carRepositoryMock;

        private void GivenCarRepositoryReturnsCars () {
            carRepositoryMock = new CarRepositorySuccessMock();
            sut = new CarService(carRepositoryMock);
        }

        private void GivenCarRepositoryReturnsEmptyCars () {
            carRepositoryMock = new CarRepositorySuccessEmptyMock();
            sut = new CarService(carRepositoryMock);
        }

        private void GivenCarRepositoryThrowException () {
            carRepositoryMock = new CarRepositoryExceptionMock();
            sut = new CarService (carRepositoryMock);
        }

        [Test]
        public void ShouldReturnCarsWhenLoadSuccess () {
            // assign
            GivenCarRepositoryReturnsCars();

            // act
            var result = sut.GetCarsByTypeAndYear(CarType.Coupe, new DateTime()) as List<Car>;

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 1);
            CollectionAssert.IsNotEmpty(result);
        }

        [Test]
        public void ShouldReturnEmptyCollectionWhenNullReturned()
        {
            // assign
            GivenCarRepositoryReturnsEmptyCars();

            // act
            var result = sut.GetCarsByTypeAndYear(CarType.Coupe, new DateTime()) as List<Car>;

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 0);
            CollectionAssert.IsEmpty(result);
        }

        [Test]
        public void ShouldReturnEmptyCollectionWhenErrorThrown()
        {
            // assign
            GivenCarRepositoryThrowException();

            // act
            var result = sut.GetCarsByTypeAndYear(CarType.Coupe, new DateTime()) as List<Car>;

            // assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 0);
            CollectionAssert.IsEmpty(result);
        }
    }
}