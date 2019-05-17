using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Assigment_Directive_Unit
{     
    class Program
    {
        static string gen = string.Empty;
        static void BarbatsauFemeie()
        { 
            Console.WriteLine();

               
            Console.Write("Sex: ");
            Console.ForegroundColor = ConsoleColor.Blue;
                    string sex = Console.ReadLine();
            Console.ResetColor();
                    if (sex == "feminin")
                        gen = "doamna";
                    else if (sex == "masculin")
                        gen = "domnul";
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Aceasta applicatie nu este pentru roboti!");
                        Console.ResetColor();
                                Console.ReadKey();
                                System.Environment.Exit(0);
                    }
        }

        static void Inserare()
        {
                     Console.Write("Nume: ");
             Console.ForegroundColor = ConsoleColor.DarkRed;
                     string nume = Console.ReadLine();
             Console.ResetColor();


                     Console.Write("Prenume: ");
             Console.ForegroundColor = ConsoleColor.DarkRed;
                     string prenume = Console.ReadLine();
             Console.ResetColor();
            
                     Console.WriteLine();

                     Console.Write("Adresa: ");
             Console.ForegroundColor = ConsoleColor.Blue;
                     string adresa = Console.ReadLine();
             Console.ResetColor();
            
                     Console.Write("Judet: ");
             Console.ForegroundColor = ConsoleColor.Blue;
                     string judet = Console.ReadLine();
             Console.ResetColor();

                     Console.Write("Cod postal: ");
             Console.ForegroundColor = ConsoleColor.Blue;
                     string cod = Console.ReadLine();
             Console.ResetColor();
                        
                     Console.WriteLine();

                     Console.Write("Telefon: ");
             Console.ForegroundColor = ConsoleColor.DarkRed;
                     string tel = Console.ReadLine();
             Console.ResetColor();

                     Console.Write("email: ");
             Console.ForegroundColor = ConsoleColor.DarkRed;
                     string email = Console.ReadLine();
             Console.ResetColor();

                     Console.WriteLine();

             Console.ForegroundColor = ConsoleColor.DarkRed;
                     Console.WriteLine("Datele dvs au fost colectate!");
             Console.ResetColor();
                     Console.WriteLine();
        }

        static void Timer()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Se verifica datele dvs... ");
            Console.ResetColor();
                    Console.WriteLine();
                            var magie = Console.CursorTop;
                                for (int a = 5; a >= 0; a--)
                                {
                                        Console.Write("\rProcesul de #RANDOMIZARE se va incheia in {0} secunde.", a);
                                        System.Threading.Thread.Sleep(1000);
                                        Console.SetCursorPosition(0, magie);
                                }
        }
        
        static void Afisare()
        {            
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Bine ati venit ");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"{gen} {nume} {prenume}");
            Console.ResetColor();

            Console.Write(" la #RANDOMIZARE unde R. A. D. U. va afisa #CEVA");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Adresa dvs este: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{adresa} {judet} {cod}");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Recomand realocare la o adresa #RANDOM ");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Instructiuni pentru realocare vor fi trimise pe ");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"{email}");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("R. A. D. U ");
            Console.ResetColor();

            Console.Write("te va suna de indata ce ajungi la locatie, pe numarul ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"{tel}");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("Ai grija sa nu ramai fara baterie la telefon!");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("Calatorie placuta!");
            Console.ResetColor();
                       
        } 

        
       /* static void Main(string[] args)
        {
            Console.WriteLine("Bine ati venit la Random Assignment Directive Unit.");            //  R. A. D. U.
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Doriti sa initializam procesul de #RANDOMIZARE? (DA/NU)");      // sponsored by KFC
            Console.ResetColor();

            Console.Write("Raspuns: ");

            string start = Console.ReadLine();
            switch (start.ToLower())
            {
                case "da":
                    Inserare();
                    break;

                case "nu":
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Raspuns incorect! Mai incercam odata? (DA/NU)");
                    Console.ResetColor();

                    Console.Write("Raspuns: ");
                    string info = Console.ReadLine();

                    const string D = "da";

                    const string N = "nu";

                    switch (info.ToLower())
                    {
                        case D:
                            Inserare();
                            break;

                        case N:
                            System.Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Raspuns gresit! Apasati tasta Enter pentru a inchide sesiunea.");
                            Console.ResetColor();

                            Console.ReadLine();
                            System.Environment.Exit(0);
                            break;
                    }
                    break;

            }

            Console.ReadKey();

        } */

    }

}
    








           




                            

            
            
                    
           
           
            
           


           
           
    


  