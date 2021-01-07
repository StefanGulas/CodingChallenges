using System.Collections.Generic;

namespace CodingChallenges
{
  public class Autocomplete
  {
    public List<string> GetWords(List<string> StringList, char prefix)
    {
      var resultStringList = new List<string>();
      foreach (var item in StringList)
      {
        if (item[0] == prefix) resultStringList.Add(item);
      }
      return resultStringList;
    }

  }
}
