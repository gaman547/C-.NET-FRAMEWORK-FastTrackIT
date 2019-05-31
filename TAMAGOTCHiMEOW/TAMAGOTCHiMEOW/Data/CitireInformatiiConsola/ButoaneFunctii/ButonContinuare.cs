using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMAGOTCHiMEOW
{
    public class ButonContinuare
    {
        public static bool MeniuAlegeNume = true;
        public static void AlegeNume()
        {
            Console.WriteLine($"Introduceti nume {IntroducereSexAnimal.gender} : ");
            string NumeAnimal = IntroducereNumePisica.Nume();

            while (MeniuAlegeNume)
            {
                IntroducereNumePisica.Nume();
            }

            if (MeniuAlegeNume == false)
            {
                ButonIesire.CountDown();
                System.Environment.Exit(0);
            }
        }
    }
}