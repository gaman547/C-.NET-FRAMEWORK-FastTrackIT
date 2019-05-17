using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_3
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
            double pozitiv = (double)arr.Where(x => x > 0).Count() / (double)arr.Length;
            double negativ = (double)arr.Where(x => x < 0).Count() / (double)arr.Length;
            double zero = (double)arr.Where(x => x == 0).Count() / (double)arr.Length;

            Console.WriteLine(String.Format("{0:0.000000}", pozitiv));
            Console.WriteLine(String.Format("{0:0.000000}", negativ));
            Console.WriteLine(String.Format("{0:0.000000}", zero));

            Console.ReadKey();
        } 
    }
}
