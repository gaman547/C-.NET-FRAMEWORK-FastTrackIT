using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace AlarmaEveniment
{
    public class IntroducereNume
    {
        public static string nume = string.Empty;
        public static string Nume()
        {
            nume = Console.ReadLine().TrimStart(' ').TrimEnd(' ');

            if (string.IsNullOrEmpty(nume) || string.IsNullOrWhiteSpace(nume))
            {
                Console.WriteLine();
                Console.WriteLine("Va rog sa introduceti un nume!"); 
            }
            else if (!string.IsNullOrEmpty(nume) && nume.Length <= 2)
            {
                Console.WriteLine();
                Console.WriteLine("A-ti introdus mai putin de 3 caractere! cele mai scurte nume de baieti/fete au cel putin 3 caractere!");
            }            
            else if (nume == "Exit" || nume == "exit")
            {
                System.Environment.Exit(0);
            }           
                return nume;
        }
    }
}