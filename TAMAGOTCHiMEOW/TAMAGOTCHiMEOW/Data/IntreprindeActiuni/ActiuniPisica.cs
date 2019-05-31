using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMAGOTCHiMEOW
{
    public class ActiuniPisica
    {
        static Pisica pisica = new Pisica();
        public  static void mananca()
        {
            pisica.Hraneste();
        }

        public static void stare()
        {
            pisica.AfiseazaStare1();
        }

        public static  void apa()
        {
            pisica.BeaApa();
        }

        public static void somn()
        {
            pisica.Doarme();
        }

        public static void joc()
        {
            pisica.Joaca();
        }

        public static void AtentionariMancare()
        {
            if(RecunoasteActiuniPrestabilite.contorMancare == 3 || RecunoasteActiuniPrestabilite.contorMancare == 6 || RecunoasteActiuniPrestabilite.contorMancare == 9)
            {
                pisica.PisicaGrasa();                
            }

            if(RecunoasteActiuniPrestabilite.contorSomn == 3 || RecunoasteActiuniPrestabilite.contorSomn == 6 || RecunoasteActiuniPrestabilite.contorSomn == 9)
            {
                pisica.PisicaSomnoroasa();
            }
        }

        public static void Veterinar()
        {
            pisica.Medic();
        }
    }
}