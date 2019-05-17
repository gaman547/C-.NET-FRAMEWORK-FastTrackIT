using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_codul_morse
{
    public class Introducere
    {
        public static string propozitie = string.Empty;
        public static string Text()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            propozitie = Console.ReadLine().TrimStart(' ').TrimEnd(' ');
            Console.ResetColor();

            if (!string.IsNullOrEmpty(propozitie))
            {
                propozitie = propozitie.ToLower();
            }
            return propozitie;
        }
    }
}