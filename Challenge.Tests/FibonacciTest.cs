using System;
using Challenge.Compute;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge.Tests
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void Should_Pass_When_NIsGreaterThan100()
        {
            int result = FibonacciSequence.Calculate(102);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Should_Pass_When_NIsSmallerThan1()
        {
            int result = FibonacciSequence.Calculate(-10);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Should_Pass_When_ExpectedResultsAreReturned()
        {
            int result = FibonacciSequence.Calculate(6);
            Assert.AreEqual(8, result);
        }
    }
}
