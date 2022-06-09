using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities.Interfaces;

namespace InterviewTests
{
    [TestClass]
    public class NumberOrdinalTest
    {
        [TestMethod]
        public void NumberOrdinal()
        {
            IOrdinalHelper helper = null;
			
            Assert.AreEqual(helper.GetNumberWithOrdinal(1), "1st");
            Assert.AreEqual(helper.GetNumberWithOrdinal(2), "2nd");
            Assert.AreEqual(helper.GetNumberWithOrdinal(3), "3rd");
            Assert.AreEqual(helper.GetNumberWithOrdinal(4), "4th");
            Assert.AreEqual(helper.GetNumberWithOrdinal(20), "20th");
            Assert.AreEqual(helper.GetNumberWithOrdinal(21), "21st");
            Assert.AreEqual(helper.GetNumberWithOrdinal(22), "22nd");
            Assert.AreEqual(helper.GetNumberWithOrdinal(23), "23rd");
            Assert.AreEqual(helper.GetNumberWithOrdinal(24), "24th");
        }
    }
}