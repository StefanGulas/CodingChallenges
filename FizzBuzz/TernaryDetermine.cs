using System;

namespace FizzBuzz
{
  public class TernaryDetermine
  {
    public void Determine(int totalNumber, int fizz, int buzz)
    {
      for (int i = 1; i < totalNumber; i++)
      {
        Console.WriteLine((Convert.ToBoolean(i % fizz) ? "" : "Fizz") + (Convert.ToBoolean(i % buzz) ? "" : "Buzz") + ((Convert.ToBoolean(i % fizz) && Convert.ToBoolean(i % buzz)) ? i.ToString() : ""));
      }
    }


  }
}
