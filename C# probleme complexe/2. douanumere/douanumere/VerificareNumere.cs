using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace douanumere
{
   public class VerificareNumere
   {
        public static void MicSauMare()
        {
            if (Program.first < Program.second)
            {
                for (int i = Program.first; i < Program.second + 1; i++)
                {
                    Console.Write(i + " ");
                }
            }
            else if (Program.first > Program.second)
            {
                for (int i = Program.first; i > Program.second - 1; i--)
                {
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