using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMAGOTCHiMEOW
{
    public class ActiuniMotan 
    {
        static Pisica motan = new Pisica();
        public static void mananca()
        {
            motan.Hraneste();
        }

        public static void stare()
        {
            motan.AfiseazaStare1();
        }

        public static void apa()
        {
            motan.BeaApa();
        }

        public static void somn()
        {
            motan.Doarme();
        }

        public static void joc()
        {
            motan.Joaca();
        }

        public static void AtentionariMancare()
        {
            if (RecunoasteActiuniPrestabilite.contorMancare >= 3)
            {
                motan.PisicaGrasa();
            }

            if (RecunoasteActiuniPrestabilite.contorSomn == 3)
            {
                motan.PisicaSomnoroasa();
            }
        }

        public static void Veterinar()
        {
            motan.Medic();
        }

    }
}