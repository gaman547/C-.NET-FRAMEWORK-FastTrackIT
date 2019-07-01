using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FermaAnimalelor.Hrana;
using FermaAnimalelor.Infrastructura;
using FermaAnimalelor.Resurse;

namespace FermaAnimalelor.Animale
{
    class Porc : Animal
    {
        public override string Rasa => "porc";

        public override IHrana[] HranaPreferata => new IHrana[] { new Laturi(), new Cereale() };

        public override int NumarPicioare => 4;

        public override bool ManancaDeDouaOri => true;



        public override IResursa ColecteazaResurse()
        {
            return new Carne();
        }
    }
}
