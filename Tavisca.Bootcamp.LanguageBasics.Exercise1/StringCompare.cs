using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    public class StringCompare
    {
        public string StringComparer(string actualNumbers, string numberWithUnknownDigits)
        {
            //here we will comapare both strings character wise and check what number will be suitable in place of '?'.
            int j = 0;
            string outputDigit = "";
            char[] actualNumber = actualNumbers.ToCharArray();
            char[] numberWithUnknownDigit = numberWithUnknownDigits.ToCharArray();
            for (int i = 0; i < actualNumber.Length; i++)
            {
                if (actualNumber[i] != numberWithUnknownDigit[i])
                {
                    j++;
                    if (actualNumber[i] == '?')
                    {
                        outputDigit = numberWithUnknownDigit[i] + "";
                    }
                    else
                    {
                        outputDigit = actualNumber[i] + "";
                    }
                }
            }
            if (j != 1)
            {
                outputDigit = "-1";
            }
            return outputDigit;
        }
    }
}
