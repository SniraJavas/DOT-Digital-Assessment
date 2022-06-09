using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities.Interfaces;

namespace InterviewTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Calculator()
        {
            ICalculator calculator = null;
		
            Assert.AreEqual(calculator.Calculate("1 + 1"), 2);
            Assert.AreEqual(calculator.Calculate("201 - 201"), 0);
            Assert.AreEqual(calculator.Calculate("50 - 45 + 45"), 50);
            Assert.AreEqual(calculator.Calculate("1 + 5 + 100 - 26"), 80);
            Assert.AreEqual(calculator.Calculate("1 + 1 + 1 - 1 - 1 + 1"), 2);
        }
    }
}