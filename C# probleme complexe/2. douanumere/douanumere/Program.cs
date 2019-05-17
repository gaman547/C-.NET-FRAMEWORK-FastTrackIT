using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace douanumere
{
    class Program
    {
        public static int first, second;
        static void Main(string[] args)
        {
            Console.Write("choose first number: ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("second number: ");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            VerificareNumere.MicSauMare();
            Console.ReadKey();
        }
    }
}