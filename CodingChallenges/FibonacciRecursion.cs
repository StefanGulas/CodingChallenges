using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
  public class FibonacciRecursion : IFibonacci
  {
    public List<long> CalculateFibonacci(long position)
    {
      var fibonacci = new List<long>();
      fibonacci.Add(0);
      if (position == 0) return fibonacci;
      for (int i = 1; i <= position; i++)
      {
        fibonacci.Add(CalculateOneFibonacci(i));
      }
      return fibonacci;
    }
    private long CalculateOneFibonacci(long fibonacciLong)
    {
      if (fibonacciLong == 0) return 0;
      if (fibonacciLong == 1) return 1;
      else return CalculateOneFibonacci(fibonacciLong - 1) + CalculateOneFibonacci(fibonacciLong - 2);
    }
  }
}
