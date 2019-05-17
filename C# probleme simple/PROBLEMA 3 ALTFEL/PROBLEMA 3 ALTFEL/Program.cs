using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_3_ALTFEL
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            PlusMinus(arr);
        }
     
        static void PlusMinus(int[] arr)
        {
            double pozitiv = 0, negativ = 0, zero = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    double number = Convert.ToInt32(arr[i]);
                    if (number > 0)
                    {
                        pozitiv += 1;
                    }
                    else if (number < 0)
                    {
                        negativ += 1;
                    }
                    else if (number == 0)
                    {
                        zero += 1;
                    }
                }

                Console.WriteLine(String.Format("{0:0.000000}", (pozitiv / arr.Length)));
                Console.WriteLine(String.Format("{0:0.000000}", (negativ / arr.Length)));
                Console.WriteLine(String.Format("{0:0.000000}", (zero / arr.Length)));

                Console.ReadKey();
        }
    }
}