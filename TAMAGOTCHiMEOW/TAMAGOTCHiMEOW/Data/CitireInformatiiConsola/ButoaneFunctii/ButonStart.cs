using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMAGOTCHiMEOW
{
    public class ButonStart
    {
        public static bool MeniuAlegeSex = true;
        public static void AlegeSex()
        {
            Console.WriteLine("Alege dintre pisica sau motan.");
            Console.Write("Raspuns: ");
            string SexAnimal = IntroducereSexAnimal.Gender();

            while (MeniuAlegeSex)
            {
                IntroducereSexAnimal.Gender();
            }

            if (MeniuAlegeSex == false)
            {
                ButonIesire.CountDown();
                System.Environment.Exit(0);
            }
        }
    }
}