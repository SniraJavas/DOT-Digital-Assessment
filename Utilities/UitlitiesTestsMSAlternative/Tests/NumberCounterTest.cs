using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities.Interfaces;

namespace InterviewTests
{
    [TestClass]
    public class NumberCounterTest
    {
        [TestMethod]
        public void CountNumbers()
        {
            INumberCounter counter = null;
			
            Assert.AreEqual(counter.CountNumbers("1"), 1);
            Assert.AreEqual(counter.CountNumbers("1x"), 1);
            Assert.AreEqual(counter.CountNumbers("999x"), 3);
            Assert.AreEqual(counter.CountNumbers("abc1234x"), 4);
            Assert.AreEqual(counter.CountNumbers(" / * 4 ttt 8|"), 2);
        }
    }
}