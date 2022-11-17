using System;
using System.Text.RegularExpressions;


namespace PhoneNumberLibrary
{
    public class PhoneNumber
    {
        public static MatchCollection NumberSearch(ref string str, Regex pattern)
        {
            MatchCollection numbers = pattern.Matches(str);
            str = Regex.Replace(str, pattern.ToString(), "");
            return numbers;
        }

        public static string[] Conversion(MatchCollection collectionOfNum)
        {
            string[] arrayOfNum = new string[collectionOfNum.Count];

            for (int i = 0; i < collectionOfNum.Count; i++)
            {
                arrayOfNum[i] = collectionOfNum[i].Value;
            }

            return arrayOfNum;
        }
    }
}
