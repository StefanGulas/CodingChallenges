using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodingChallenges;
using NUnit.Framework;

namespace CodingChallengesTests
{
  public class FibonacciTests
  {
    [Test]
    public void EqualsIfPositionIs8()
    {
      var fibonacci = new Fibonacci();
      var expectedFibonacciList = new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13 };
      int position = 8;
      var actualFibonacciList = fibonacci.CalculateFibonacci(position);

      Assert.IsTrue(actualFibonacciList.SequenceEqual(expectedFibonacciList));
    }
  }
}
