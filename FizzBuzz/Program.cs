using System;

namespace FizzBuzz
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 100; i++)
      {
        if (i % 3 == 0)
        {
          if (i % 5 == 0)
          {
            Console.WriteLine("FizzBuzz");
            continue;
          }
          Console.WriteLine("Fizz");
          continue;
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine("Buzz");
          continue;
        }
        Console.WriteLine(i);
      }
      
      
      Console.WriteLine("Hello World!");
    }
  }
}
