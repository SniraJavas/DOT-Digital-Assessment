using NUnit.Framework;
using Utilities.Interfaces;
using Utilities.Repository;

namespace InterviewTests
{
    [TestFixture]
    public class NumberCounterTest
    {
        [TestCase("1", 1)]
        [TestCase("1x", 1)]
        [TestCase("999x", 3)]
        [TestCase("abc1234x", 4)]
        [TestCase(" / * 4 ttt 8|", 2)]
        public void CountNumbers(string input, int expectedCount)
        {
            INumberCounter counter = new NumberCounter();

            var result = counter.CountNumbers(input);

            Assert.That(result, Is.EqualTo(expectedCount));
        }
    }
}