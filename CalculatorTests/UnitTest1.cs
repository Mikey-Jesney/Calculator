using NUnit.Framework;
using CalculatorLib;
namespace CalculatorTests
{
    public class StaticCalculatorTests
    {

        [TestCase(4, 8, 12)]
        [TestCase(-1, 8, 7)]
        [TestCase(4, -2, 2)]

        public void AddTest(int num1, int num2,
        int expectedResult)
        {
            var result = StaticCalculator.Add(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(2, 8, 16)]
        [TestCase(0, 8, 0)]
        [TestCase(5, 2, 10)]

        public void MulTest(int num1, int num2,
        int expectedResult)
        {
            var result = StaticCalculator.Mul(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(8, 4, 4)]
        [TestCase(4, 2, 2)]
        [TestCase(4, 1, 3)]

        public void SubTest(int num1, int num2,
        int expectedResult)
        {
            var result = StaticCalculator.Sub(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(4, 2, 2)]
        [TestCase(4, 4, 1)]
        [TestCase(4, 1, 4)]

        public void DivTest(int num1, int num2,
        int expectedResult)
        {
            var result = StaticCalculator.Div(num1, num2);
            Assert.AreEqual(expectedResult, result);
        }

    }
}
