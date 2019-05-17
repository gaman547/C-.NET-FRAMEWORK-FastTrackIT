using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Palindrom
{
    public class VerificarePalindrom
    {
        public static bool CheckPalindrom(string cuvant)
        {
            char[] verificare = Program.cuvant.ToCharArray();
            Array.Reverse(verificare);
            return new string(verificare).Equals(cuvant);
        }
    }
}