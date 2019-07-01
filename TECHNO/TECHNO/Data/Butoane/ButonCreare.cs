using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHNO
{
    public class ButonCreare
    {
        public static void CreareAnimal()
        {
            Pisica pisica = new Pisica();
            Motan motan = new Motan();           
           
            if (IntroducereSexAnimal.gender == "motan")
            {
                if (IntroducereCuloare.AlegeCuloare == "albastru")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine($"Ai ales un {IntroducereSexAnimal.gender} cu numele {IntroducereNumeAnimal.nume}");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("Are urmatoarele valori implicite: ");

                    motan.AfiseazaStare();

                    IntroducereActiuniAnimal.Comanda();
                }

                if (IntroducereCuloare.AlegeCuloare == "rosu")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine($"Ai ales un {IntroducereSexAnimal.gender} cu numele {IntroducereNumeAnimal.nume}");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("Are urmatoarele valori implicite: ");

                    motan.AfiseazaStare();

                    IntroducereActiuniAnimal.Comanda();
                }

                if (IntroducereCuloare.AlegeCuloare == "verde")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine($"Ai ales un {IntroducereSexAnimal.gender} cu numele {IntroducereNumeAnimal.nume}");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("Are urmatoarele valori implicite: ");

                    motan.AfiseazaStare();

                    IntroducereActiuniAnimal.Comanda();
                }

                if (IntroducereCuloare.AlegeCuloare == "roz")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    Console.WriteLine($"Ai ales un {IntroducereSexAnimal.gender} cu numele {IntroducereNumeAnimal.nume}");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("Are urmatoarele valori implicite: ");

                    motan.AfiseazaStare();

                    IntroducereActiuniAnimal.Comanda();
                }

                if (IntroducereCuloare.AlegeCuloare == "galben")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine($"Ai ales un {IntroducereSexAnimal.gender} cu numele {IntroducereNumeAnimal.nume}");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("Are urmatoarele valori implicite: ");

                    motan.AfiseazaStare();

                    IntroducereActiuniAnimal.Comanda();
                }
            }
            else if (IntroducereSexAnimal.gender == "pisica")
            {
                if (IntroducereCuloare.AlegeCuloare == "albastru")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine($"Ai ales o {IntroducereSexAnimal.gender} cu numele {IntroducereNumeAnimal.nume}");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("Are urmatoarele valori implicite: ");

                    pisica.AfiseazaStare();

                    IntroducereActiuniAnimal.Comanda();
                }

                if (IntroducereCuloare.AlegeCuloare == "rosu")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine($"Ai ales o {IntroducereSexAnimal.gender} cu numele {IntroducereNumeAnimal.nume}");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("Are urmatoarele valori implicite: ");

                    pisica.AfiseazaStare();

                    IntroducereActiuniAnimal.Comanda();
                }

                if (IntroducereCuloare.AlegeCuloare == "verde")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine($"Ai ales o {IntroducereSexAnimal.gender} cu numele {IntroducereNumeAnimal.nume}");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("Are urmatoarele valori implicite: ");

                    pisica.AfiseazaStare();

                    IntroducereActiuniAnimal.Comanda();
                }

                if (IntroducereCuloare.AlegeCuloare == "roz")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    Console.WriteLine($"Ai ales o {IntroducereSexAnimal.gender} cu numele {IntroducereNumeAnimal.nume}");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("Are urmatoarele valori implicite: ");

                    pisica.AfiseazaStare();

                    IntroducereActiuniAnimal.Comanda();
                }

                if (IntroducereCuloare.AlegeCuloare == "galben")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine($"Ai ales o {IntroducereSexAnimal.gender} cu numele {IntroducereNumeAnimal.nume}");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.WriteLine("Are urmatoarele valori implicite: ");

                    pisica.AfiseazaStare();

                    IntroducereActiuniAnimal.Comanda();
                }
            }
        }
    }
}