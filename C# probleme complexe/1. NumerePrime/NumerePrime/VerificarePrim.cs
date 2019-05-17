using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerePrime
{
    public class VerificarePrim
    {
        public static bool CalculPrim(int numar)
        {
            if (numar == 1)   // 1 nu este numar prim
                return false;
            for(int x = 2; x < numar; x++)  // am pornit variabila x de la 2 deoarece 2 este cel mai mic numar prim
            {
                if ((numar % x == 0))   // x find cel mai mic numar prim, facem aceasta verificare deoarece : definitie numar prim = numarul prim se imparte la 1 si la el insusi.
                    return false;      // automat daca se imparte si la cel mai mic numar prim, acesta nu mai este prim. haha   
            }
            return true;
        } 
    }
}