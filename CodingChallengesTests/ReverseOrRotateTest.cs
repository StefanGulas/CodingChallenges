using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CodingChallenges;

namespace CodingChallengesTests
{
    public class ReverseOrRotateTest
    {
        [Test]
        public void Equals0IfPositionIs0()
        {
            char[] expected = new[] { 'o', 'l', 'l', 'e', 'h' };
            ReverseStringSolution reverseStringSolution = new ReverseStringSolution();
            char[] input = new[] { 'h', 'e', 'l', 'l', 'o' };
            char[] actual = reverseStringSolution.ReverseString(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
