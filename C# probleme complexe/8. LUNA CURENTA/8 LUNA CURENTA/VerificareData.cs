using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_LUNA_CURENTA
{
    public class VerificareData
    {
        public static int Anul = Convert.ToInt32(DateTime.Today.Year);
        public static int Luna = Convert.ToInt32(DateTime.Today.Month);
        public static int Zile = DateTime.DaysInMonth(Anul, Luna);
    }
}