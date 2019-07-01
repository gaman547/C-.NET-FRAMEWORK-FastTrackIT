using FermaAnimalelor.Infrastructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaAnimalelor.Resurse
{
    class Carne : IResursa
    {
        public int Cantitate => 100;

        public string UnitateDeMasura => "kg";
    }
}
