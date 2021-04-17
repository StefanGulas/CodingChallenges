using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    public class ReverseOrRotate
    {
        public static string RevRot(string inputString, int sz)
        {
            if (sz <= 0 || inputString == String.Empty || sz > inputString.Length) return "";
            int sum = 0;
            foreach (var item in inputString)
            {
                sum += item ^ 3;
            }
            string [] resultArray = new string[inputString.Length];
            int j = 0;
            if(sum % 2 == 0)
            {
                for (int i = inputString.Length-1; i >= 0; i--)
                {
                    resultArray[j] = Char.ToString(inputString[i]);
                    j++;
                }
            }
            else
            {
                resultArray[inputString.Length - 1] = Char.ToString(inputString[0]);
                for (int i = 1; i < inputString.Length-2; i++)
                {
                    resultArray[j] = Char.ToString(inputString[i]);
                    j++;
                }
            }
            return string.Join("", resultArray);
        }
    }
}
