using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHNO
{
    public class Pisica : InterfataAnimal
    {
        private int energie = 20;
        private int foame = 60;
        private int fericire = 40;
        private int sete = 60;
        private decimal greutate = 0.50m;
        private int sanatate = 91;

        public virtual int Energie { get { return energie; } set { energie = value; } }
        public virtual int Foame { get { return foame; } set { foame = value; } }
        public virtual int Fericire { get { return fericire; } set { fericire = value; } }
        public virtual int Sete { get { return sete; } set { sete = value; } }
        public virtual decimal Greutate { get { return greutate; } set { greutate = value; } }
        public virtual int Sanatate { get { return sanatate; } set { sanatate = value; } }      

        public virtual void AfiseazaStare()
        {
            Console.WriteLine();
            Console.WriteLine($"Energie : {energie}");
            Console.WriteLine($"Foame : {foame}");
            Console.WriteLine($"Fericire : {fericire}");
            Console.WriteLine($"Sete : {sete}");
            Console.WriteLine($"Greutate : {greutate}");
            Console.WriteLine($"Sanatate : {sanatate}");
        }

        public virtual void Hraneste()
        {
            energie += 10;
            foame -= 10;
            fericire += 10;
            sete += 10;
            greutate += 0.10m;
            sanatate += 1;
            if (sete >= 80)
            {
                Console.WriteLine("Ar prinde bine niste apa");
            }
            if (greutate >= 3.00m)
            {
                Console.WriteLine($"{IntroducereSexAnimal.gender} {IntroducereNumeAnimal.nume} a depasit 3kg. ai grija ");
            }
        }

        public virtual void BeaApa()
        {
            energie += 5;
            foame += 5;
            fericire += 5;
            sete -= 30;
            greutate += 0.05m;
            sanatate += 2;
            if (sete <= 20)
            {
                Console.WriteLine($"{IntroducereSexAnimal.gender} {IntroducereNumeAnimal.nume} are nevoie de apa");
            }
            if (foame >= 70)
            {
                Console.WriteLine("mi fomita");
            }
            if (greutate >= 3.00m)
            {
                Console.WriteLine($"{IntroducereSexAnimal.gender} {IntroducereNumeAnimal.nume} a depasit 3kg. ai grija ");
            }
            if (sete <= 20)
            {
                Console.WriteLine("am baut destula apa");
            }
        }

        public virtual void HaiLaJoaca()
        {
            energie -= 20;
            foame += 20;
            fericire += 20;
            sete += 20;
            greutate -= 0.20m;
            sanatate += 3;
            if (energie <= 20)
            {
                Console.WriteLine($"{IntroducereSexAnimal.gender} {IntroducereNumeAnimal.nume} a atins pragul de 20% energie. be sure to rest.");
            }
            if (sete >= 80)
            {
                Console.WriteLine($"{IntroducereSexAnimal.gender} {IntroducereNumeAnimal.nume} a cam baut apa...");
            }
            if (foame >= 70)
            {
                Console.WriteLine("mi fomita");
            }
        }

        public virtual void HaiLaSomn()
        {
            energie += 40;
            foame += 10;
            fericire += 10;
            sete += 20;
            sanatate += 5;
            if (sete <= 20)
            {
                Console.WriteLine($"{IntroducereSexAnimal.gender} {IntroducereNumeAnimal.nume} are nevoie de apa");
            }
            if (energie >= 100)
            {
                Console.WriteLine($"{IntroducereSexAnimal.gender} {IntroducereNumeAnimal.nume} a dormit prea mult. descarca din energie");
            }
            if (foame >= 70)
            {
                Console.WriteLine("mi fomita");
            }
        }

        public virtual void Veterinar()  
        {
            energie = 20;
            foame = 60;
            fericire = 40;
            sete = 80;
            sanatate = 91;
        }

        public virtual void Grasime()
        {
            sanatate -= 20;
            energie -= 20;
            if (sanatate <= 10)
            {
                Console.WriteLine("Atentie! sanatatea a scazut la 10. mergi la veterinar.");
            }
            if (energie <= 10)
            {
                Console.WriteLine("ar prinde bine un pui de somn. pt energie");
            }
        }

        public virtual void Somn()
        {
            sanatate -= 20;
            foame -= 20;
            sete += 20;
            if (sanatate <= 10)
            {
                Console.WriteLine("Atentie! sanatatea a scazut la 10. mergi la veterinar.");
            }
            if (sete <= 20)
            {
                Console.WriteLine($"{IntroducereSexAnimal.gender} {IntroducereNumeAnimal.nume} are nevoie de apa");
            }
        }
    }
}