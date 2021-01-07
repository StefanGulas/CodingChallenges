using System;
using System.Collections.Generic;
using System.Linq;
using CodingChallenges;
using NUnit.Framework;

namespace CodingChallengesTests
{
  public class AutocompleteTest
  {
    [Test]
    public void Test1()
    {
      var autoComplete = new Autocomplete();
      var expectedListString = new List<string>() { "aba", "acd" };
      var testListString = new List<string>() { "aba", "acd", "dacd" };
      char prefix = 'a';
      var actualListString = autoComplete.GetWords(testListString, prefix);
      
      Assert.IsTrue(actualListString.SequenceEqual(expectedListString));
    }
    [Test]
    public void Test2()
    {
      var autoComplete = new Autocomplete();
      var expectedListString = new List<string>() { "dba", "dcd",  };
      var testListString = new List<string>() { "aba", "acd", "acd", "dba", "xgasöl", "dcd", "öfaäe" };
      char prefix = 'd';
      var actualListString = autoComplete.GetWords(testListString, prefix);

      Assert.IsTrue(actualListString.SequenceEqual(expectedListString));
    }
  }
}
