using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHNO
{
    public class IntroducereSexAnimal
    {
        public static string gender = string.Empty;

        public static string Gender()
        {
            gender = Console.ReadLine().TrimStart(' ').TrimEnd(' ').ToLower();

            if (string.IsNullOrEmpty(gender) || string.IsNullOrWhiteSpace(gender))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Va rog sa introduceti raspunsul corect!");
                Console.ResetColor();
            }

            foreach (char caracter in gender)
            {
                if (caracter >= 'a' && caracter <= 'z')
                {
                    if (gender != "motan" && gender != "pisica")
                    {
                        Console.WriteLine();
                        Console.WriteLine("A-ti introdus caractere gresite!");
                        Console.WriteLine();
                        ButonStart.AlegeSex();
                    }

                }
            }

            if (!string.IsNullOrEmpty(gender) && (gender.Length >= 1 && gender.Length <= 6))
            {
                if (gender == "pisica" || gender == "motan")
                {
                    Console.WriteLine();
                    Console.WriteLine($"A-ti introdus {gender}, continuati? (DA/NU)");
                    string raspuns1 = Console.ReadLine().TrimStart(' ').TrimEnd(' ');
                    switch (raspuns1.ToLower())
                    {
                        case "da":
                            Console.WriteLine();
                            ButonStart.AlegeNume();
                            break;

                        case "nu":
                            ButonStart.MeniuAlegeSex = false;
                            break;

                        default:
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Raspuns gresit! Doriti sa continuam cu aceasta alegere? (DA/NU)");
                            Console.ResetColor();

                            string raspuns2 = Console.ReadLine().TrimStart(' ').TrimEnd(' ');

                            const string DA = "da";
                            const string NU = "nu";

                            switch (raspuns2.ToLower())
                            {
                                case DA:
                                    Console.WriteLine();
                                    ButonStart.AlegeNume();
                                    break;

                                case NU:
                                    Console.WriteLine();
                                    Console.WriteLine("Va rog sa introduceti motan sau pisica : ");
                                    gender = Console.ReadLine().TrimStart(' ').TrimEnd(' ');
                                    Console.WriteLine();
                                    ButonStart.AlegeNume();
                                    break;

                                default:
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Am detectat 2 raspunsuri gresite concomitente!");
                                    Console.ResetColor();
                                    ButonStart.MeniuAlegeSex = false;
                                    break;
                            }
                            break;
                    }
                }
            }

            else
            {
                ButonStart.AlegeSex();
            }

            return gender;
        }
    }
}