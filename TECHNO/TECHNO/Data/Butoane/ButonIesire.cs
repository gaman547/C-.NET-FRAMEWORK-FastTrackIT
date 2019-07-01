using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHNO
{
    public class ButonIesire
    {
        public static void CountDown()
        {
            Console.WriteLine();
            var magie = Console.CursorTop;
            for (int a = 5; a >= 0; a--)
            {
                Console.Write("\rTAMAGOTCHiMEOW se va inchide in {0} secunde.", a);
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(0, magie);
            }
        }
    }
}