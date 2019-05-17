using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmaEveniment
{    
    public delegate string NoulMeuDelegate(string str);
    public class EvenimentBineAtiVenit
    {
        public event NoulMeuDelegate NoulMeuEveniment;

        public EvenimentBineAtiVenit()
        {
            this.NoulMeuEveniment += new NoulMeuDelegate(this.WelcomeUser);
        }

        public string WelcomeUser(string username)
        {
            Console.WriteLine();
            return "Bine ati venit " + username;
        }

        public static void Afisare()
        {
            EvenimentBineAtiVenit obiect1 = new EvenimentBineAtiVenit();
            string salut = obiect1.NoulMeuEveniment(IntroducereNume.nume);
            Console.WriteLine(salut);
        }
    }
}