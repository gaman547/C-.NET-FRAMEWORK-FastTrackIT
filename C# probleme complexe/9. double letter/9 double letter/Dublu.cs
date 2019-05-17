using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_double_letter
{
    class Dublu
    {
        public static StringBuilder textDublat = new StringBuilder();
        public static string Verificare(string textul)
        {
            foreach  (char caracter in Intro.propozitie)
            {
                if(caracter >= 'a' && caracter <='z' || caracter >= 'A' && caracter <= 'Z')
                {
                    textDublat.Append(caracter, 2);
                }
            }
            return textDublat.ToString();
        }        
    }
}