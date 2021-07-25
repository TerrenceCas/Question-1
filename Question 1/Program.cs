using System;
using System.Text.RegularExpressions;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            string customRegEx = string.Empty;
            string customVal = string.Empty;
            Console.WriteLine("The default regular expression checks for " +
                "at least one digit.");
            while (true)
            {
                Console.Write("\nEnter a regular expression " +
                    " (or press ENTER to use the default): ");
                customRegEx = Console.ReadLine();

                if (customRegEx == "")
                {
                    customRegEx = @"^[a-z]+$"; // default value
                    Console.WriteLine(customRegEx);
                }

                Console.Write("Enter some input: ");
                customVal = Console.ReadLine();
                PrintIsValid(customVal, customRegEx);

                Console.WriteLine("Press ESC to end or any key to try again.");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        static void PrintIsValid(string input, string pattern)
        {
            Regex re = new Regex($@"{pattern}");
            Console.WriteLine($"{input} matches {pattern}: {re.IsMatch(input)}");
        }
    }
}
