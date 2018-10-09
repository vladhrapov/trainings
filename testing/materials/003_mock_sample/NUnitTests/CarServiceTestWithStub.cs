using System;
using System.Collections.Generic;
using System.Linq;
using NUnit;
using NUnit.Framework;
using Moq;
using ClassLibrary;

namespace Tests {

    [TestFixture]
    public class CarServiceTest {
        private CarService sut;
        private Mock<ICarRepository> carRepositoryMock;

        private void GivenCarRepositoryReturnsCars () {
            carRepositoryMock
                .Setup(s => s.LoadCars(It.IsAny<CarType>(), It.IsAny<DateTime>()))
                .Returns(new List<Car> {
                    new Car {
                        Brand = "Ferrari",
                        Engine = "V8",
                        Price = 2435.5,
                        Type = CarType.Coupe
                    }
                });
        }

        private void GivenCarRepositoryReturnsEmptyCars () {
            carRepositoryMock
                .Setup(s => s.LoadCars(It.IsAny<CarType>(), It.IsAny<DateTime>()))
                .Returns(new List<Car>());
        }

        private void GivenCarRepositoryThrowException () {
            carRepositoryMock
                .Setup(s => s.LoadCars(It.IsAny<CarType>(), It.IsAny<DateTime>()))
                .Throws<Exception>();
        }

        [SetUp]
        public void SetUp()
        {
            carRepositoryMock = new Mock<ICarRepository>();
            sut = new CarService(carRepositoryMock.Object);
        }

        [Test]
        public void ShouldReturnCarsWhenLoadSuccess () {
            // assign
            GivenCarRepositoryReturnsCars();

            // act
            var result = sut.GetCarsByTypeAndYear(It.IsAny<CarType>(), It.IsAny<DateTime>()) as List<Car>;

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