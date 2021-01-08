using System.Collections.Generic;

namespace CodingChallenges
{
  public class Fibonacci
  {
    public List<long> CalculateFibonacci(long position)
    {
      var fibonacci = new List<long>();
      fibonacci.Add(0);
      if (position == 0) return fibonacci;
      fibonacci.Add(1);
      if (position == 1) return fibonacci;

      int fibonacciMinus1 = 1;
      int fibonacciMinus2 = 0;
      for (int i = 2; i <= position; i++)
      {
        fibonacci.Add(fibonacciMinus1 + fibonacciMinus2);
        fibonacciMinus2 = fibonacciMinus1;
        fibonacciMinus1 = (int)fibonacci[i];
      }
      return fibonacci;
    }
  }
}
