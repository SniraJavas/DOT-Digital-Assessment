using NUnit.Framework;
using Utilities.Interfaces;
using Utilities.Repository;

namespace InterviewTests
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase("1 + 1", 2)]
        [TestCase("201 - 201", 0)]
        [TestCase("50 - 45 + 45", 50)]
        [TestCase("1 + 5 + 100 - 26", 80)]
        [TestCase("1 + 1 + 1 - 1 - 1 + 1", 2)]
        public void Calculator(string expression, int expectedResult)
        {
            ICalculator calculator = new Calculator();

            var result = calculator.Calculate(expression);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}