using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHNO
{
    interface InterfataAnimal
    {
        int Energie { get; set; }
        int Foame { get; set; }
        int Fericire { get; set; }
        int Sete { get; set; }
        decimal Greutate { get; set; }
        int Sanatate { get; set; }

        void AfiseazaStare();
        void Hraneste();
        void BeaApa();
        void HaiLaJoaca();
        void HaiLaSomn();
        void Veterinar();
        void Grasime();
        void Somn();               
    }
}