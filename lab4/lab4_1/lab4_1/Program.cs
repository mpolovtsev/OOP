using System;

namespace lab4_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            Str str = new Str(Console.ReadLine());

            Console.Write("Введите слово: ");
            string word = Console.ReadLine();

            int amountOfOccurrence = str.FindOccurrence(word);
            Console.WriteLine($"Количество вхождений слова \"{word}\" в строку \"{str.str}\" равно {amountOfOccurrence}");
        }
    }
}