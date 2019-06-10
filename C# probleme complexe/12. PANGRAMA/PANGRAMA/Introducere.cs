using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PANGRAMA
{
    public class Introducere
    {
        public static string propozitie = string.Empty;
        public static string Propozitie()
        {
            propozitie = Console.ReadLine().TrimStart(' ').TrimEnd(' ').ToLower();

            if (string.IsNullOrEmpty(propozitie))
            {
                Console.WriteLine("Te rog introdu o propozitie!");
            }
            
            return propozitie;
        }
    }
}