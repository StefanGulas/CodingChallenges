namespace FizzBuzz
{
  public class DetermineFizzBuzz
  {
    public void Determine(int totalNumber, int fizz, int buzz)
    {
      for (int i = 1; i < totalNumber; i++)
      {
        if (i % fizz != 0 && i % buzz != 0) System.Console.Write(i);
        if (i % fizz == 0) System.Console.Write("Fizz");
        if (i % buzz == 0) System.Console.Write("Buzz");
        System.Console.WriteLine();
      }
    }
  }
}
