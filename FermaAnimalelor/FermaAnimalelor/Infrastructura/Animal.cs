using FermaAnimalelor.Infrastructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaAnimalelor
{
    abstract class Animal:Object
    {
        public bool AnimalHranit { get; private set; }

        public bool AnimalAdormit { get; private set; }
        public bool AnimalAdapostit { get; private set; }
        public abstract string Rasa { get; }
        public abstract int NumarPicioare { get; }

        public abstract bool ManancaDeDouaOri { get; }

       // public abstract IHrana HranaSecundara { get; }
        public abstract IHrana[] HranaPreferata { get; }

        
        public void Mananca(IHrana hrana)
        {
            foreach (var food in HranaPreferata)
            {
               if(food.Denumire == hrana.Denumire )
               {
                    AnimalHranit = true;
               }
            }            
        }

        public void Doarme()
        {
            if (AnimalHranit)
            {
                AnimalAdormit = true;
            }
           
        }

        public void Adapostire()
        {
            if(AnimalHranit && AnimalAdormit)
            {
                AnimalAdapostit = true;
            }
        }

        public abstract IResursa ColecteazaResurse();
    }
}
