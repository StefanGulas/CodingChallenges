using System;
using System.Collections.Generic;
using CodingChallenges;
using NUnit.Framework;

namespace CodingChallengesTests
{
    public class ReverseStringTest
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
