using System;

namespace lab4_1
{
    public class Str
    {
        public string str;

        public Str(string str)
        {
            this.str = str;
        }

        public int FindOccurrence(string word)
        {
            string[] subStr = str.Split(' ', '.', ',', ';', ':', '!', '?', '-', '(', ')', '"');
            int amountOfOccurrence = 0;

            foreach (string element in subStr)
            {
                if (element == word)
                {
                    amountOfOccurrence++;
                }
            }

            return amountOfOccurrence;
        }
    }
}
