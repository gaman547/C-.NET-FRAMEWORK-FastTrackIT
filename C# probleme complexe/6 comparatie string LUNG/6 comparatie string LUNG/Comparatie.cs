using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_comparatie_string_LUNG
{
    public class Comparatie
    {
        public static void VerificareSegment()
        {
            int[,] A = new int[Program.text1.Length, Program.text2.Length];
            int marime = -1;
            string segment = string.Empty;
            int end = -1;

            for (int i = 0; i < Program.text1.Length; i++)
            {
                for (int j = 0; j < Program.text2.Length; j++)
                {
                    if (Program.text1[i] == Program.text2[j])
                    {
                        if (i == 0 || j == 0)
                        {
                            A[i, j] = 1;
                        }
                        else
                            A[i, j] = A[i - 1, j - 1] + 1;
                        if (A[i, j] > marime)
                        {
                            marime = A[i, j];
                            end = i;
                        }

                    }
                    else
                        A[i, j] = 0;
                }
            }

            for (int i = end - marime + 1; i <= end; i++)
            {
                segment += Program.text1[i];
            }

            Console.WriteLine("Cel mai lung segment comun din cele 2 texte este de {0} caractere, iar acesta este = {1}", marime, segment);            
        }
    }    
}