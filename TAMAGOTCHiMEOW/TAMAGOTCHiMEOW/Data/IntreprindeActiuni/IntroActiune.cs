using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMAGOTCHiMEOW
{
    public class IntroActiune
    {

        public static bool MeniuActiune = true;
                
        public  static void Intreprinde()
        {            
            while (MeniuActiune)
            {
                Console.WriteLine();
                Console.WriteLine("Introdu actiunea pe care vrei sa o interprinzi cu animalul: ");
                string actiune = RecunoasteActiuniPrestabilite.Info();
            }
           
            if (MeniuActiune == false) 
            {
                ButonIesire.CountDown();
                System.Environment.Exit(0);
            }
        }        
    }
}