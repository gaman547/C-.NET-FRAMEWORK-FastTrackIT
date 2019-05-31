using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMAGOTCHiMEOW
{
    class RecunoasteActiuniPrestabilite
    {
        public static int contorMancare = 0;
        public static int contorSomn = 0;
        
        public static string VerificareActiune = string.Empty;

        public static string Info()
        {          
            VerificareActiune = Console.ReadLine().TrimStart(' ').TrimEnd(' ').ToLower();

            if (string.IsNullOrEmpty(VerificareActiune) || string.IsNullOrWhiteSpace(VerificareActiune))
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Va rog sa introduceti una din actiunile prestabilite!");
                Console.ResetColor();
            }

            foreach (char caracter in VerificareActiune)
            {
                if (caracter >= 'a' && caracter <= 'z')
                {
                    if ((VerificareActiune != "hraneste") && (VerificareActiune != "bea apa") && (VerificareActiune != "joaca") && (VerificareActiune != "doarme") && (VerificareActiune != "stop joc") && (VerificareActiune != "verifica stare") && (VerificareActiune != "veterinar"))
                    {
                        Console.WriteLine();
                        Console.WriteLine("A-ti introdus caractere gresite!");
                        Console.WriteLine();
                        IntroActiune.Intreprinde();
                    }
                    if (VerificareActiune == "stop joc")
                    {
                        IntroActiune.MeniuActiune = false;
                    }
                }
            }

            if (IntroducereSexAnimal.gender == "pisica")
            {
                if (VerificareActiune == "verifica stare")
                {
                    ActiuniPisica.stare();
                }

                if (VerificareActiune == "hraneste")
                {
                    ActiuniPisica.mananca();
                    contorMancare += 1;
                    ActiuniPisica.AtentionariMancare();
                }

                if (VerificareActiune == "bea apa")
                {
                    ActiuniPisica.apa();
                }

                if (VerificareActiune == "joaca")
                {
                    ActiuniPisica.joc();
                }

                if (VerificareActiune == "doarme")
                {
                    ActiuniPisica.somn();
                    contorSomn += 1;
                }

                if (VerificareActiune == "veterinar")
                {
                    ActiuniPisica.Veterinar();
                }               
            }

            if(IntroducereSexAnimal.gender == "motan")
            {
                if (VerificareActiune == "verifica stare")
                {
                    ActiuniMotan.stare();
                }

                if (VerificareActiune == "hraneste")
                {
                    ActiuniMotan.mananca();
                    contorMancare += 1;
                    ActiuniMotan.AtentionariMancare();
                }

                if (VerificareActiune == "bea apa")
                {
                    ActiuniMotan.apa();
                }

                if (VerificareActiune == "joaca")
                {
                    ActiuniMotan.joc();
                }

                if (VerificareActiune == "doarme")
                {
                    ActiuniMotan.somn();
                    contorSomn += 1;
                }

                if (VerificareActiune == "veterinar")
                {
                    ActiuniMotan.Veterinar();
                }
            }

            return VerificareActiune;

        }      
    }
}