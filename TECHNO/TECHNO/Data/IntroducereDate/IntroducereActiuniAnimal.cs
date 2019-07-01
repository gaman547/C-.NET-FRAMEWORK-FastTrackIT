using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHNO
{
    public class IntroducereActiuniAnimal
    {
        public static bool MeniuActiuni = true;

        public static int contorMancare = 0;
        public static int contorSomn = 0;

        public static string VerificareActiune = string.Empty;

        public static string Comanda()
        {
            Pisica pisica = new Pisica();
            Motan motan = new Motan();

            while(MeniuActiuni)
            {
                Console.WriteLine();
                Console.WriteLine("hraneste, bea apa, verifica stare, joaca, doarme, veterinar, stop joc");
                Console.WriteLine("Introdu actiunea pe care vrei sa o interprinzi cu animalul: ");

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
                            Comanda();
                        }
                        if (VerificareActiune == "stop joc")
                        {
                            MeniuActiuni = false;
                        }
                    }
                }

                if(IntroducereSexAnimal.gender == "motan")
                {
                    if(VerificareActiune == "verifica stare")
                    {
                        motan.AfiseazaStare();
                    }
                    
                    if(VerificareActiune == "hraneste")
                    {
                        motan.Hraneste();
                        contorMancare += 1;
                        if (contorMancare == 3 || contorMancare == 6 || contorMancare == 9)
                        {
                            motan.Grasime();
                        }
                    }

                    if(VerificareActiune == "bea apa")
                    {
                        motan.BeaApa();
                    }

                    if(VerificareActiune == "joaca")
                    {
                        motan.HaiLaJoaca();
                    }

                    if(VerificareActiune == "doarme")
                    {
                        motan.HaiLaSomn();
                        contorSomn += 1;
                        if(contorSomn == 3 || contorSomn == 6 || contorSomn == 9)
                        {
                            motan.Somn();
                        }
                    }

                    if(VerificareActiune == "veterinar")
                    {
                        motan.Veterinar();
                        contorMancare = 0;
                        contorSomn = 0;
                    }
                }

                if (IntroducereSexAnimal.gender == "pisica")
                {
                    if (VerificareActiune == "verifica stare")
                    {
                        pisica.AfiseazaStare();
                    }

                    if (VerificareActiune == "hraneste")
                    {
                        pisica.Hraneste();
                        contorMancare += 1;
                        if (contorMancare == 3 || contorMancare == 6 || contorMancare == 9)
                        {
                            pisica.Grasime();
                        }
                    }

                    if (VerificareActiune == "bea apa")
                    {
                        pisica.BeaApa();
                    }

                    if (VerificareActiune == "joaca")
                    {
                        pisica.HaiLaJoaca();
                    }

                    if (VerificareActiune == "doarme")
                    {
                        pisica.HaiLaSomn();
                        contorSomn += 1;
                        if (contorSomn == 3 || contorSomn == 6 || contorSomn == 9)
                        {
                            pisica.Somn();
                        }
                    }

                    if (VerificareActiune == "veterinar")
                    {
                        pisica.Veterinar();
                        contorMancare = 0;
                        contorSomn = 0;
                    }
                }
            }

            if (MeniuActiuni == false)
            {
                ButonIesire.CountDown();
                System.Environment.Exit(0);
            }

            return VerificareActiune;
        }
    }
}