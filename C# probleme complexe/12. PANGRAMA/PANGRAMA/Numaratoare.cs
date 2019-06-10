using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PANGRAMA
{
    public class Numaratoare
    {      
        public static void Litere()
        {
            string alfabet = "abcdefghijklmnopqrstuvwxyz";

            int NumarBucati = 0;

            foreach (char a in alfabet)
            {
                foreach (char b in Program.pangram)
                {
                    if (a == b)
                    {
                        NumarBucati++;
                        break;
                    }
                }
            }

            if (NumarBucati == 26)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Propozitia este PANGRAM");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Propozitia NU este PANGRAM");
                Console.ResetColor();
            }
        }
    }
}
