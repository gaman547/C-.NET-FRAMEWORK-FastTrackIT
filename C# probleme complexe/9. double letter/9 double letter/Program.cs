using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_double_letter
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti text: ");
            string text = Intro.Text();
            Console.WriteLine("Literele au fost dublate: ");
            Console.Write(Dublu.Verificare(text));
            Console.ReadKey();
        }                
    }
}