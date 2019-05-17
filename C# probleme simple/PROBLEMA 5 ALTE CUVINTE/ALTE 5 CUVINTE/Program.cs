using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTE_5_CUVINTE
{
    class Program
    {
        static void Main(string[] args)
        {
            Citire();
            Calcul();
            Afisare();
        }

        static string propozitie = string.Empty;
        static string Citire()
        {
            Console.Write("Va rog sa introduceti un text: ");
            propozitie = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"A-ti introdus textul: {propozitie}");
            Console.WriteLine();

            return propozitie;
        }
      // static char[] simboluri = { ',', '.', '/', ';', ':', '"', '|',  };
        static int cuvinte = 1;
        static void Calcul()
        {
            int a = 0;
            while (a <= propozitie.Length - 1)
            {
                if (propozitie[a] == ' ' || propozitie[a] == '\n' )
                {
                     cuvinte++;
                }
                a++;
            }                      
        }
        static void Afisare()
        {
            Console.WriteLine($"Acest text contine {cuvinte} cuvinte.");
            Console.ReadKey();
        }
    }
}