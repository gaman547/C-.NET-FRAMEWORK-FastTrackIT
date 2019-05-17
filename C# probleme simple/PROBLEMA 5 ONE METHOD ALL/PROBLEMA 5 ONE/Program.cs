using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_5_ONE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Va rog sa introduceti un text: ");
            string propozitie = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"A-ti introdus textul: {propozitie}");
            Console.WriteLine();

            int cuvinte = 0;
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

            Console.WriteLine($"Acest text contine {cuvinte} cuvinte.");
            Console.ReadKey();
        }
    }
}
