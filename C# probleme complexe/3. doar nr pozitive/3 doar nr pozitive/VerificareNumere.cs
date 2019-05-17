using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_doar_nr_pozitive
{
    public class VerificareNumere
    {
        public static void Conditie()
        {
            if (Program.first < Program.second)
            {
                for (int i = Program.first; i < Program.second ; i++)
                {
                    i++;
                    Console.Write(i + " ");
                }                  
            }
            else if (Program.first > Program.second)
            {
                for (int i = Program.first; i > Program.second ; i--)
                {
                    i--;
                    Console.Write(i + " ");                    
                }
            }
            else
            {
                Console.WriteLine("Numerele sunt egale");
            }
        }
    }
}