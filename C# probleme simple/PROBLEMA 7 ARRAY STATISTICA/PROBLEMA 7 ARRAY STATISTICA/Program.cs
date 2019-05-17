using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_7_ARRAY_STATISTICA
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroDate();
            PrelucrareDate();
            AfisarePozitive();
            Console.WriteLine();
            AfisareNegative();
            Console.WriteLine();
            AfisareZero();
            Console.ReadKey();            
        }

        static int CifraMagica;
        static int[] numere;
        static void IntroDate ()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Cate numere doriti sa introduceti pe urmatorul rand? : ");
            Console.ResetColor();
            CifraMagica = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Numere: ");
            Console.ResetColor();
            numere = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Console.WriteLine();            
        }

        static int pozitive, negative, zero;
        static void PrelucrareDate()
        {
            for (int i = 0; i < numere.Length; i++)
            {
                if(numere[i] > 0)
                {
                   pozitive++;                   
                }
                else if(numere[i] < 0)
                {
                   negative++;
                }
                else
                {
                   zero++;
                }
            }            
        }

        static void AfisarePozitive()
        {
            Console.WriteLine($"numere pozitive: {pozitive}");
            for (int i = 0; i < numere.Length; i++)
            {
                if(numere[i] > 0)
                {
                    Console.Write(numere[i] + " ");
                }                
            }                    
        }

        static void AfisareNegative()
        {
            Console.WriteLine($"numere negative: {negative}");
            for (int i = 0; i < numere.Length; i++)
            {
                if(numere[i] < 0)
                {
                    Console.Write(numere[i] + " ");
                }
            }             
        }

        static void AfisareZero()
        {
            Console.WriteLine($"numere zero: {zero}");
            for (int i = 0; i < numere.Length; i++)
            {
                if(numere[i] == 0)
                {
                    Console.Write(numere[i] + " ");
                }
            }             
        }        
    }
}