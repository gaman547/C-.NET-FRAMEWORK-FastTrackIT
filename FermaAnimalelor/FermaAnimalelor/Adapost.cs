using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaAnimalelor
{
    class Adapost : IAdapost
    {      
              
        int IAdapost.NumarAnimale { get => numar; set => numar = value; }
        int IAdapost.CapacitateAdapost { get => numarCapacitate; set => numarCapacitate = value; }
        
        private int numar = 0;

        protected int numarCapacitate = 7;

        public void EnterAdapost()
        {
            if (numar < numarCapacitate)
            {
                numar += 1;
            }
        }

        public void Afisare()
        {
            Console.WriteLine(numar);
        }
    }
}
