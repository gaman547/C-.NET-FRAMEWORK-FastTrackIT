using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmaEveniment
{
    public delegate string NoulMeuDelegateAlarma();
    public class EvenimentAlarma
    {
        public event NoulMeuDelegateAlarma NoulMeuEvenimentAlarma;

        public EvenimentAlarma()
        {
            this.NoulMeuEvenimentAlarma += new NoulMeuDelegateAlarma(this.AlarmaUser);
        }

        public string AlarmaUser()
        {            
                Console.WriteLine();
                return "Alarma!";          
        }

        public static void Afisare()
        {
            EvenimentAlarma obiect1 = new EvenimentAlarma();
            string alerta = obiect1.NoulMeuEvenimentAlarma();
            Console.WriteLine(alerta);
        }
    }
}