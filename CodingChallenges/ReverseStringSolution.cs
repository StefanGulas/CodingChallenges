using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges
{
    public class ReverseStringSolution
    {
        public char[] ReverseString(char[] s)
        {
            List<char> result = s.OfType<char>().ToList();
            int i = 0;
            int j = result.Count - 1;
            while(i <= j)
            {
                var helper = result[j];
                result[j] = result[i];
                result[i] = helper;
                i++;
                j--;
            }
            s = result.ToArray();
            return s;
        }
    }
}
