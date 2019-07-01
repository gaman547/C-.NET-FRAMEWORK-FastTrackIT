using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FermaAnimalelor.Infrastructura;
using FermaAnimalelor.Resurse;

namespace FermaAnimalelor
{
     class Iepure : Animal
    {
        public override string Rasa => "iepure";
        public override IHrana[] HranaPreferata => new IHrana[] { new Morcov() };

        public override int NumarPicioare => 4;

        public override bool ManancaDeDouaOri => false;

        public override IResursa ColecteazaResurse()
        {
            return new Oua();
        }
    }
}
