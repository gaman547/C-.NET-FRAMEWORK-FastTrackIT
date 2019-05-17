using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_LUNA_CURENTA
{
    public class CitireData
    {
        public static DateTime LunaCurenta = DateTime.Now;
        public static string AfisareLunaCurenta = LunaCurenta.ToString("MMMMMMMMMM");
    }
}