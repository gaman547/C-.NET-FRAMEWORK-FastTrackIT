using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_comparatie_string_LUNG
{
    class Program
    {
        public static string text1, text2 = string.Empty;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" text 1: ");
            Console.ResetColor();
            text1 = Console.ReadLine().TrimStart().TrimEnd();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" text 2: ");
            Console.ResetColor();
            text2 = Console.ReadLine();
            Console.WriteLine();

            Comparatie.VerificareSegment();
            Console.ReadKey();
        }
    }
}