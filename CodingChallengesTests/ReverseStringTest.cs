using System;
using System.Collections.Generic;
using System.Text;
using NUnit;

namespace CodingChallengesTests
{
    public class ReverseStringTest
    {
        [Test]
        public void Equals0IfPositionIs0()
        {
            var expectedFibonacciList = new List<long>() { 0 };
            int position = 0;
            var actualFibonacciList = fibonacci.CalculateFibonacci(position);

            Assert.IsTrue(actualFibonacciList.SequenceEqual(expectedFibonacciList));
        }
    }
}
