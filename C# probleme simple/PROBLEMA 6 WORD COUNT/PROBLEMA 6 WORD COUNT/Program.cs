using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_6_WORD_COUNT
{
    class Program
    {
        static void Main(string[] args)
        {
            CitireText();
            StergeSpatiu();
            CalculWord();
            Rezultat();
        }

        static string text = string.Empty;
        static string CitireText()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"            Va rog sa introduceti un text, care poate contine una sau mai multe propozitii.
            Propozitia poate fi scrisa utilizand litere mari, litere mici (doar din alfabetul latin),
            cifre, si alte caractere (cum ar fi virgula, exclamatie, punct, etc.)");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("Introduceti text: ");
                   text = Console.ReadLine();
            return text;                       
        }

        static void StergeSpatiu()
        {
            Console.WriteLine();
            Console.WriteLine("A-ti introdus urmatorul text: {0}", text.TrimStart(' ').TrimEnd(' '));

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Apasati orice tasta pentru a afisa numarul total de cuvinte din acest text!");
            Console.ResetColor();
            
            Console.ReadKey();
        }

        static int word = 1;
        static void CalculWord()
        {
            int a = 0;
            while (a <= text.Length -1)
            {
                if (text[a] == ' ')
                {
                    word++; 
                }
                a++;
            }

        }            
            /* string[] cuvinte = text.Split(' ');
            Console.WriteLine("numar: " + cuvinte.Length); */
        static void Rezultat()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            if (word == 1)
            {
                Console.Write($"Acest text contine {word} cuvant.");
            }
            else
            {
                Console.Write($"Acest text contine {word} cuvinte.");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}