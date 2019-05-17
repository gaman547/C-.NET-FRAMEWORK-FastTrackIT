using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LKKT__LNKT
{
    class Program
    {
        static void Main(string[] args)
        {
            CitireNumere();
            Verificare.MicMare();
            Afisare();
            Console.ReadKey();
        }

            public static int[] numere;
            public static int mare, mic;

        public static void CitireNumere()
        {
            Console.WriteLine("Va rog sa introduceti un sir de numere...separate prin spatiu");
            numere = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        public static void Afisare()
        {
            Console.WriteLine("cel mai mare numar: {0}", mare);
            Console.WriteLine("cel mai mic numar: {0}", mic);
        }  
    }    
}