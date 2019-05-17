using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _8_LUNA_CURENTA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bun venit!");
            Console.WriteLine();                  
                      
            Console.WriteLine($"Total zilelor din luna curenta ({CitireData.AfisareLunaCurenta}), este: {VerificareData.Zile} de zile.");
            Console.ReadKey();
        }
    }
}