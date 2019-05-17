using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_codul_morse
{
    public class Traducere
    {
        public static string TextInCod(string text)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char caracter in Introducere.propozitie)
            {
                if (Citire.CodulMorse.ContainsKey(caracter))
                {
                    stringBuilder.Append(Citire.CodulMorse[caracter] + " ");
                }
                else if (caracter == ' ')
                {
                    stringBuilder.Append("/ ");
                }
                else
                {
                    stringBuilder.Append(caracter + " ");
                }
            }
            return stringBuilder.ToString();
        }
    }
}