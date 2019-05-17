using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_5_CUVINTE
{
    class Program
    {
        public static string propozitie = string.Empty;
        static void CitireInfo()
        {
            Console.Write("Va rog sa introduceti un text: ");
            string propozitie = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"A-ti introdus textul: {propozitie}");
            Console.WriteLine();                      
        }

        public static int cuvinte = 0;
        static int CalculCuvinte()
        {            
            for (int i = 1; i < propozitie.Length; i++)
            {
                if (char.IsWhiteSpace(propozitie[i - 1]) == true)
                {
                    if (char.IsLetterOrDigit(propozitie[i]) == true || char.IsPunctuation(propozitie[i]))
                    {
                        cuvinte++;
                    }
                }
            }
                if (propozitie.Length > 2)
                {
                cuvinte++;
                }
            return cuvinte;                                   
        }

        static void Main(string[] args)
        {
            CitireInfo();
            CalculCuvinte();
            Console.WriteLine($"{ cuvinte}");
            Console.ReadKey();
        }        
    }
}