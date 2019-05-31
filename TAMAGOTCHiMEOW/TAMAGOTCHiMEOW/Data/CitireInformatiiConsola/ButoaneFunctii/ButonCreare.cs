using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMAGOTCHiMEOW
{
    class ButonCreare
    {
        public static void CreareAnimal()
        {
            if (IntroducereSexAnimal.gender == "motan")
            {
                Console.Clear();
                Console.WriteLine($"Ai ales un {IntroducereSexAnimal.gender} cu numele {IntroducereNumePisica.nume}");                                              
                
                IntroActiune.Intreprinde();              
            }
            else if (IntroducereSexAnimal.gender == "pisica")
            {
                Console.Clear();
                Console.WriteLine($"Ai ales o {IntroducereSexAnimal.gender} cu numele {IntroducereNumePisica.nume}");
                
                IntroActiune.Intreprinde();                
            }
        }
    }
}