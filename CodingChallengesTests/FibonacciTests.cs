using System;
using System.Collections.Generic;
using System.Linq;
using CodingChallenges;
using NUnit.Framework;

namespace CodingChallengesTests
{
  public class FibonacciTests
  {
    [Test]
    public void Equals0IfPositionIs0()
    {
      var fibonacci = new Fibonacci();
      var expectedFibonacciList = new List<long>() { 0 };
      int position = 0;
      var actualFibonacciList = fibonacci.CalculateFibonacci(position);

      Assert.IsTrue(actualFibonacciList.SequenceEqual(expectedFibonacciList));
    }
    [Test]
    public void Equals01IfPositionIs1()
    {
      var fibonacci = new Fibonacci();
      var expectedFibonacciList = new List<long>() { 0, 1 };
      int position = 1;
      var actualFibonacciList = fibonacci.CalculateFibonacci(position);

      Assert.IsTrue(actualFibonacciList.SequenceEqual(expectedFibonacciList));
    }
    [Test]
    public void Equals011IfPositionIs2()
    {
      var fibonacci = new Fibonacci();
      var expectedFibonacciList = new List<long>() { 0, 1, 1 };
      int position = 2;
      var actualFibonacciList = fibonacci.CalculateFibonacci(position);

      Assert.IsTrue(actualFibonacciList.SequenceEqual(expectedFibonacciList));
    }
    [Test]
    public void Equals0112IfPositionIs3()
    {
      var fibonacci = new Fibonacci();
      var expectedFibonacciList = new List<long>() { 0, 1, 1, 2 };
      int position = 3;
      var actualFibonacciList = fibonacci.CalculateFibonacci(position);

      Assert.IsTrue(actualFibonacciList.SequenceEqual(expectedFibonacciList));
    }
    [Test]
    public void Equals011235813IfPositionIs7()
    {
      var fibonacci = new Fibonacci();
      var expectedFibonacciList = new List<long>() { 0, 1, 1, 2, 3, 5, 8, 13 };
      int position = 7;
      var actualFibonacciList = fibonacci.CalculateFibonacci(position);

      Assert.IsTrue(actualFibonacciList.SequenceEqual(expectedFibonacciList));
    }
    [Test]
    public void EqualsLargeNumberIfPositionIs20()
    {
      var fibonacci = new Fibonacci();
      var expectedFibonacciList = new List<long>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 };
      int position = 20;
      var actualFibonacciList = fibonacci.CalculateFibonacci(position);

      Assert.IsTrue(actualFibonacciList.SequenceEqual(expectedFibonacciList));
    }
    [Test]
    public void EqualsLargeNumberIfPositionIs30()
    {
      var fibonacci = new Fibonacci();
      var expectedFibonacciList = new List<long>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040 };
      int position = 30;
      var actualFibonacciList = fibonacci.CalculateFibonacci(position);

      Assert.IsTrue(actualFibonacciList.SequenceEqual(expectedFibonacciList));
    }
    [Test]
    public void EqualsLargeNumberIfPositionIs5000000()
    {
      var fibonacci = new Fibonacci();
      var expectedFibonacciList = new List<long>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040 };
      long position = 500000000;
      var actualFibonacciList = fibonacci.CalculateFibonacci(position);

      Assert.IsTrue(actualFibonacciList.SequenceEqual(expectedFibonacciList));
    }


  }
}
