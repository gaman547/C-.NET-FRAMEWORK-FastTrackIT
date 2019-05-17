using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerePrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voi afisa numerele prime de la 1 la 100. editati codul sursa pentru alte numere.");
            Console.WriteLine();
                        
            for (int i = 1; i < 100; i++)  // edit aici pt alte numere. am pus 1 deoarece 0 e zero :)) 
            {
                bool prim = VerificarePrim.CalculPrim(i);
                if (prim)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}