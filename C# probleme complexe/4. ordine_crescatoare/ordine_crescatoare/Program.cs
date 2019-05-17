using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordine_crescatoare
{
    class Program
    {
        static void Main(string[] args)
        {
            CitireNumere();
            BubbleSort.SortareBubble();
            Console.ReadLine();
        }

        public static int[] numere;
        public static void CitireNumere()
        {
            Console.WriteLine("Va rog sa introduceti un sir de numere...separate prin spatiu");
            numere = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }        
    }
}