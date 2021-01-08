using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
  public class Fibonacci
  {
    public List<int> CalculateFibonacci(int position)
    {
      var fibonacci = new List<int>();
      fibonacci.Add(0);
      if (position == 0) return fibonacci;
      fibonacci.Add(1);
      if (position == 1) return fibonacci;
      fibonacci.Add(1);
      if (position == 2) return fibonacci;
      int fibonacciMinus1 = 1;
      int fibonacciMinus2 = 1;
      for (int i = 3; i <= position; i++)
      {
        fibonacci.Add(fibonacciMinus1 + fibonacciMinus2);
        fibonacciMinus2 = fibonacciMinus1;
        fibonacciMinus1 = fibonacci[i];
      }
      return fibonacci;
    }
  }
}
