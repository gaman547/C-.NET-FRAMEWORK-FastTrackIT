using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pentru a incepe va rog sa scrieti formula de adresare (domnul/doamna): ");
            string formula = Console.ReadLine();
            switch (formula.ToLower())
            {                       
                       case "domnul":
                       Console.WriteLine();
                       break;
                                  
                       case "doamna":
                       Console.WriteLine();
                       break;
 
                       default:
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine("Raspuns incorect!");
                       Console.WriteLine("Apasati oricare tasta pentru a inchide sesiunea.");
                       Console.ReadKey();
                       System.Environment.Exit(0);
                       Console.ResetColor();
                       break;
            }

            Console.Write("Nume: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string nume = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Prenume: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string prenume = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Adresa: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string adresa = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Judet: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string judet = Console.ReadLine();
            Console.ResetColor();
            
            Console.Write("Cod postal: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string cod = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Telefon: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string tel = Console.ReadLine();
            Console.ResetColor();

            Console.Write("email: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            string email = Console.ReadLine();
            Console.ResetColor();

                Console.WriteLine();
                Console.WriteLine("Datele dvs au fost prelucrate si afisate.");
                Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Persoana: ");
                        Console.ResetColor();
                        Console.Write($"{formula} {nume} {prenume} ");
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Adresa: ");
                        Console.ResetColor();
                        Console.Write($"{adresa} {judet} {cod} ");
                        Console.WriteLine();
            
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Date de contact: ");
                        Console.ResetColor();
                        Console.WriteLine($"{tel} {email} ");
            
                Console.ReadKey();
        }
    }
}