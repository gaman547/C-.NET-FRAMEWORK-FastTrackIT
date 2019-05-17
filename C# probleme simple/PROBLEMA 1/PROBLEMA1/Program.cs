using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            string numar = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Calculating...");
            Console.Write("Ready! Press any key to proceed...");
            Console.ReadKey();
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine($"{numar} {numar} {numar} {numar}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{numar}{numar}{numar}{numar}");
            Console.WriteLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{numar} {numar} {numar} {numar}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{numar}{numar}{numar}{numar}");
            Console.WriteLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Successful!");
            Console.ResetColor();
            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();

        }
    }
}
