using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_codul_morse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"         Salut! Introdu un text iar eu voi afisa acel text in codul morse.
                                Atentie! Doar cifre si litere! Spatiul va fi ilustrat cu semnul /");
            Console.WriteLine();
            string text = Introducere.Text();
            Console.WriteLine();

            Citire.Dictionar();

            Console.WriteLine("Textul tau arata cam asa... ");
            Console.WriteLine();

            Console.Write(Traducere.TextInCod(text));

            Console.ReadKey();
        }                 
    }
}