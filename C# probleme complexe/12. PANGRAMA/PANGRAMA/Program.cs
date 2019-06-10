using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PANGRAMA
{
    class Program
    {
        public static string pangram = string.Empty;
        static void Main(string[] args)
        {
            Console.WriteLine("Buna! Te pot ajuta cu verificarea unei propozitii... daca este PANGRAM sau NU.");
            Console.WriteLine();
            Console.WriteLine("Te rog sa introduci propozitia dedesubt: ");

            pangram = Introducere.Propozitie();
            
            Numaratoare.Litere();                    
          
            Console.ReadLine();
        }
    }
}