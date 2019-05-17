using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = string.Empty;
            Console.Write("Choose Number To Display: ");
            number = Console.ReadLine();

                     int No = int.Parse(number);
            Console.WriteLine();

            string size = string.Empty;
            Console.Write("Choose Size: ");
            size = Console.ReadLine();

                     int size_No = int.Parse(size);
            Console.WriteLine();

            Console.Write("Press Enter For Result...");
            Console.ReadLine();
            Console.WriteLine();

                     int magic = size_No;

                     for (int i = 0; i < magic; i++)
                     {
                         for (int j = 0; j < size_No ; j++)
                         {
                              Console.Write(No);
                         }
                              Console.WriteLine();
                              size_No--;
                     }
            
            Console.ReadKey();                              

        }
    }
}
