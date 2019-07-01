using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHNO
{
    public class IntroducereCuloare
    {
        public static string AlegeCuloare = string.Empty;

        public static bool MeniuCuloare = true;
        public static string Alege()
        {
            while (MeniuCuloare)
            {
                Console.WriteLine();
                Console.WriteLine("Albastru, Rosu, Galben, Verde, Roz.");
                Console.Write("Alege o culoare: ");
                
                AlegeCuloare = Console.ReadLine().TrimStart(' ').TrimEnd(' ').ToLower();

                if (string.IsNullOrEmpty(AlegeCuloare) || string.IsNullOrWhiteSpace(AlegeCuloare))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Va rog sa introduceti una din culorile disponibile!");
                    Console.ResetColor();
                }

                foreach (char caracter in AlegeCuloare)
                {
                    if (caracter >= 'a' && caracter <= 'z')
                    {
                        if ((AlegeCuloare != "rosu") && (AlegeCuloare != "albastru") && (AlegeCuloare != "galben") && (AlegeCuloare != "verde") && (AlegeCuloare != "roz") && (AlegeCuloare != "stop joc"))
                        {
                            Console.WriteLine();
                            Console.WriteLine("A-ti introdus caractere gresite!");
                            Console.WriteLine();
                            Alege();
                        }
                        if (AlegeCuloare == "stop joc")
                        {
                            MeniuCuloare = false;
                        }
                        if((AlegeCuloare == "rosu") || (AlegeCuloare == "albastru") || (AlegeCuloare == "galben") || (AlegeCuloare == "verde") || (AlegeCuloare == "roz"))
                        {
                            ButonCreare.CreareAnimal();
                        }
                    }
                }
                if (MeniuCuloare == false)
                {
                    ButonIesire.CountDown();
                    System.Environment.Exit(0);
                }
            }
            return AlegeCuloare;
        }
    }
}