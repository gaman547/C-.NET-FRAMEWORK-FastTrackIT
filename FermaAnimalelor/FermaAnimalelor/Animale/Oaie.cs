using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FermaAnimalelor.Hrana;
using FermaAnimalelor.Infrastructura;
using FermaAnimalelor.Resurse;

namespace FermaAnimalelor
{
    class Oaie : Animal
    {
        public override string Rasa => "oaie";

        public override IHrana[] HranaPreferata => new IHrana[] { new Fan() };

        public override int NumarPicioare => 4;

        public override bool ManancaDeDouaOri => false;

        public override IResursa ColecteazaResurse()
        {
            return new Lapte();
        }
    }
}
