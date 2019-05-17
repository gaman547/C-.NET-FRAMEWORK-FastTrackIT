using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlarmaEveniment
{           
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Introduceti exit pentru a opri programul.");
            Console.ResetColor();
            bool Meniu = true;
            while (Meniu)
            {
                NameLoopMenu();
            }                    
        }

        public static bool NameLoopMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Va rog sa scrieti un nume : ");
            string name = IntroducereNume.Nume();

            if (IntroducereNume.nume == "Marius" || IntroducereNume.nume == "marius" ||
                   IntroducereNume.nume == "Catalin" || IntroducereNume.nume == "catalin")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                EvenimentAlarma.Afisare();
                Console.ResetColor();
            }
            else if( name.Length >= 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                EvenimentBineAtiVenit.Afisare();
                Console.ResetColor();
            }
            return true;
        }
    }
}