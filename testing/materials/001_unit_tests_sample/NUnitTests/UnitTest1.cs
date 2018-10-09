using ClassLibrary;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    class CalculatorTest
    {
        private Calculator calc;
 
        [SetUp]
        public void Setup()
        {
            // assign
            calc = new Calculator();
        }

        [Test]
        public void ShouldAddTwoNumbers()
        {
            // act
            var result = calc.Add(3, 5);

            // assert
            Assert.AreEqual(8, result);    // 3 + 5 = 8.
        }

        [Test]
        public void ShouldSubTwoNumbers()
        {
            // act
            var result = calc.Sub(6, 2);

            // assert
            Assert.AreEqual(4, result);    // 6 - 2 = 4.
        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            // act
            var result = calc.Div(6, 3);

            // assert
            Assert.AreEqual(2, result);    // 6 / 3 = 2.
        }

        [Test]
        public void ShouldDivideTwoNumbers()
        {
            // act
            var result = calc.Mul(8, 3);

            // assert
            Assert.AreEqual(24, result);    // 8 * 3 = 24.
        }

        [Test]
        public void ShouldCheckNegativeCaseTwoNumbers()
        {
            // act
            var result = calc.Add(3, 5);

            // assert
            Assert.AreNotEqual(9, result); // 3 + 5 != 9.
        }
    }
}