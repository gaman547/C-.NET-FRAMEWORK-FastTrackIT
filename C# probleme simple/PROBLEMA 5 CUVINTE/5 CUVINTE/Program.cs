using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CUVINTE
{
    class Program
    {
        static void Main(string[] args)
        {
            Citire();
            Calcul();
            Afisare();
        }

        static string propozitie = "";
            static string Citire()
            {
                Console.Write("Va rog sa introduceti un text: ");
                propozitie = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine($"A-ti introdus textul: {propozitie}");
                Console.WriteLine();

                return propozitie;
            }

       static int cuvinte = 0;
        static void Calcul()
        {
            for (int i = 1; i < propozitie.Length; i++)
            {
                if (char.IsWhiteSpace(propozitie[i - 1]) == true)
                {
                    if (char.IsLetter(propozitie[i]) == true || char.IsPunctuation(propozitie[i]))
                    {
                        cuvinte++;
                    }
                }
            }
            if (propozitie.Length >= 1)
            {
                cuvinte++;
            }
        }
        static void Afisare()
        {
            Console.WriteLine($"Acest text contine {cuvinte} cuvinte.");
            Console.ReadKey();
        } 
    }
}
