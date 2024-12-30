using System;
using System.Text.RegularExpressions;

namespace Solution
{
    public static class FreeUrinals
    {
        public static int GetFreeUrinals(string urinals)
        {
            //Have fun :)
            if (urinals.Contains("11"))
            {
                return -1;
            }

            int freeUrinals = 0;
            char[] urinalArray = urinals.ToCharArray();
            for (int i = 0; i < urinalArray.Length; i++)
            {
                if (urinalArray[i] == '0' &&
                    (i == 0 || urinalArray[i - 1] != '1') &&
                    (i == urinalArray.Length - 1 || urinalArray[i + 1] != '1'))
                {
                    urinalArray[i] = '1';
                    freeUrinals++;
                }
            }
            return freeUrinals;

            // Alternative
            // return urinals.Contains("11") ? -1 : Regex.Matches(urinals, @"(^|0)0(?!1)").Count;
        }

    }
}