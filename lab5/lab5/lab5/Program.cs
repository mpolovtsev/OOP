using System;
using System.Text.RegularExpressions;
using PhoneNumberLibrary;

namespace lab5
{
    class Program
    {
        public static void Print(string[] arrayOfNum, string header)
        {
            Console.WriteLine($"{header}");

            if (arrayOfNum.Length == 0)
            {
                Console.WriteLine("Массив пуст.");
            }
            else
            {
                for (int i = 0; i < arrayOfNum.Length; i++)
                {
                    Console.WriteLine($"{arrayOfNum[i]}");
                }
            }
        }

        static void Main(string[] args)
        {
            string[] arrayOfNum = new string[6] {"+375 (29) 144-23-59", "8-029-312-66-15", 
                "+375 (29) 723-23-01", "+375 (44) 521-04-18", "7", "8-023-310-91-25"};
            string stringOfNum = String.Join(" ", arrayOfNum);

            Regex mobilePhonePattern = new Regex(@"\+375\s\(\d{2}\)\s\d{3}-\d{2}-\d{2}");
            Regex cityPhonePattern = new Regex(@"8-\d{2,4}-\d{3}-\d{2}-\d{2}");
            Regex incorrectValPattern = new Regex(@"\w+");

            MatchCollection mobilePhone = PhoneNumber.NumberSearch(ref stringOfNum, mobilePhonePattern);
            MatchCollection cityPhone = PhoneNumber.NumberSearch(ref stringOfNum, cityPhonePattern);
            MatchCollection incorrectVal = PhoneNumber.NumberSearch(ref stringOfNum, incorrectValPattern);

            string[] arrayOfMobilePhone = PhoneNumber.Conversion(mobilePhone);
            string[] arrayOfCityPhone = PhoneNumber.Conversion(cityPhone);
            string[] arrayOfIncorrectVal = PhoneNumber.Conversion(incorrectVal);

            Print(arrayOfMobilePhone, "Мобильные телефоны:");
            Print(arrayOfCityPhone, "Городские телефоны:");
            Print(arrayOfIncorrectVal, "Некорректные значения:");
        }
    }
}