using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_double_letter
{
    public class Intro
    {
        public static string propozitie = string.Empty;
        public static string Text()
        {
            propozitie = Console.ReadLine().TrimStart(' ').TrimEnd(' ');
            
            if (string.IsNullOrEmpty(propozitie))
            {
                Console.WriteLine("please try again");
            }
            return propozitie;
        }
    }
}