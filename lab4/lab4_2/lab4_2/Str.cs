using System;
using System.Text.RegularExpressions;
using System.Text;

namespace lab4_2
{
    public class Str
    { 
        public static string[] FormationNewText(StringBuilder str, string pattern)
        {
            Regex re = new Regex(pattern);
            MatchCollection matches = re.Matches(str.ToString());
            string[] arrOfString = new string[matches.Count];

            for (int i = 0; i < arrOfString.Length; i++)
            {
                arrOfString[i] = matches[i].ToString();
            }

            return arrOfString;
        }
    }
}
