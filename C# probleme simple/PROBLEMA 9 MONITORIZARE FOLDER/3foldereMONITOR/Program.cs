using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3foldereMONITOR
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"    Directoarele SHARP 1 2 3 sunt monitorizate pentru creare de fisier/e nou, redenumire fisier/e,
                                                      stergere fisier/e si schimbare tip fisier/e.
                                  Aceste informatii(evenimente) sunt redate in consola in timp real.
                                  Apasati orice tasta pentru a oprii programul.");
            Console.WriteLine();

            MonitorizareCreare.EvenimenteCreare();
            MonitorizareRename.EvenimenteRename();
           // MonitorizareSchimbare.EvenimenteSchimbare();
            MonitorizareStergere.EvenimenteStergere();

            Console.ReadKey();
        }
    }
}