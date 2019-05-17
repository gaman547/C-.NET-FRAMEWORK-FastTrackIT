using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Palindrom
{
    class Program
    {
        public static string cuvant = string.Empty;
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti cuvant: ");
            cuvant = Console.ReadLine();

            Console.WriteLine($"cuvantul introdus este palindrom? Raspuns: {VerificarePalindrom.CheckPalindrom(cuvant)}");
            Console.ReadKey();
        }
    }
}
