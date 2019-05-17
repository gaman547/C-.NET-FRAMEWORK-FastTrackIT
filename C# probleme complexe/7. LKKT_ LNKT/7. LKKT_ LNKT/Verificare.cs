using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LKKT__LNKT
{
    public class Verificare
    {
        public static void MicMare()
        {
            for (int i = 0; i < Program.numere.Length; i++)
            {                           
                 Program.mare = Program.numere.Max();
                 Program.mic = Program.numere.Min();  
            }
        }
    }
}