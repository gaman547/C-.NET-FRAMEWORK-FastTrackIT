using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHNO
{
    public class ButonStart
    {
        public static bool MeniuAlegeSex = true;

        public static bool MeniuAlegeNume = true;

        public static void AlegeSex()
        {
            Console.WriteLine("Alege dintre pisica sau motan");
            Console.Write("Raspuns: ");
            string SexAnimal = IntroducereSexAnimal.Gender();

            while(MeniuAlegeSex)
            {
                IntroducereSexAnimal.Gender();
            }

            if(MeniuAlegeSex == false)
            {
                ButonIesire.CountDown();
                System.Environment.Exit(0);
            }
        }

        public static void AlegeNume()
        {

            Console.WriteLine($"Introduceti nume {IntroducereSexAnimal.gender} : ");
            string NumeAnimal = IntroducereNumeAnimal.Nume();
            while (MeniuAlegeNume)
            {
                IntroducereNumeAnimal.Nume();
            }

            if (MeniuAlegeNume == false)
            {
                ButonIesire.CountDown();  
                System.Environment.Exit(0);
            }
        }

       
    }
}