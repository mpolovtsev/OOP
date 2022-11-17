using System;
using System.Text;
using System.Text.RegularExpressions;

namespace lab4_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            StringBuilder str = new StringBuilder(Console.ReadLine());
            string pattern = @"[А-Яа-я]+[\.\,\;\:\?\!]*";

            string[] arrOfString = Str.FormationNewText(str, pattern);

            foreach (string element in arrOfString)
            {
                Console.Write(element + " ");
            }
        }
    }
}
