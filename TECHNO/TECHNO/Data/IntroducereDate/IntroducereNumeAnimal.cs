using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHNO
{
    public class IntroducereNumeAnimal
    {
        public static string nume = string.Empty;

        public static string Nume()
        {
            nume = Console.ReadLine().TrimStart(' ').TrimEnd(' ');      

            if (string.IsNullOrEmpty(nume) || string.IsNullOrWhiteSpace(nume) || nume.Length <= 2)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Va rog sa introduceti un nume!");
                Console.ResetColor();
            }

            else if ((!string.IsNullOrEmpty(nume) || string.IsNullOrWhiteSpace(nume)) && nume.Length >= 3)
            {
                Console.WriteLine();
                Console.WriteLine($"A-ti introdus numele: {nume}, continuati? (DA/NU)");
                string raspuns1 = Console.ReadLine().TrimStart(' ').TrimEnd(' ');
                switch (raspuns1.ToLower())
                {
                    case "da":
                        IntroducereCuloare.Alege();
                        ButonCreare.CreareAnimal();

                        break;

                    case "nu":
                        ButonStart.MeniuAlegeNume = false;
                        break;

                    default:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Raspuns gresit! Doriti sa continuam cu acest nume sau o schimbam? (DA/NU)");
                        Console.ResetColor();

                        string raspuns2 = Console.ReadLine().TrimStart(' ').TrimEnd(' ');

                        const string DA = "da";
                        const string NU = "nu";

                        switch (raspuns2.ToLower())
                        {
                            case DA:
                                IntroducereCuloare.Alege();
                                ButonCreare.CreareAnimal();

                                break;

                            case NU:
                                Console.WriteLine();
                                Console.WriteLine("Va rog sa introduceti un nume!");
                                Nume();

                                break;

                            default:
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Am detectat 2 raspunsuri gresite concomitente!");
                                Console.ResetColor();
                                ButonStart.MeniuAlegeNume = false;
                                break;
                        }
                        break;
                }
            }
            return nume;
        }
    }
}