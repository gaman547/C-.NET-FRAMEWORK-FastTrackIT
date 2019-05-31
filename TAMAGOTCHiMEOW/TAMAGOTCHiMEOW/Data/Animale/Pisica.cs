using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAMAGOTCHiMEOW
{
    class Pisica
    {
        private  int energie = 20;
        private int foame = 60;
        private int fericire = 40;
        private int sete = 60;        
        private decimal greutate = 0.50m;
        private int sanatate = 99;

        public int Energie { get { return energie; } }
        public int Foame { get { return foame; } }
        public int Fericire { get { return fericire; } }
        public int Sete { get { return sete; } }
        public decimal Greutate { get { return greutate; } }
        public int Sanatate { get { return sanatate; } }
        
        public void AfiseazaStare1()
        {
            Console.WriteLine($"Energie : {energie}");
            Console.WriteLine($"Foame : {foame}");
            Console.WriteLine($"Fericire : {fericire}");
            Console.WriteLine($"Sete : {sete}");            
            Console.WriteLine($"Greutate : {greutate}");
            Console.WriteLine($"Sanatate : {sanatate}");
        }

        public void Hraneste()
        {
            energie += 10;
            foame -= 10;
            fericire += 10;
            sete += 10;
            greutate += 0.10m;
            sanatate += 1;
            if(sete >= 80)
            {
                Console.WriteLine("Ar prinde bine niste apa");
            }
            if(greutate >= 3.00m)
            {
                Console.WriteLine($"{IntroducereSexAnimal.gender} a depasit 3kg. ai grija ");
            }
        }

        public void BeaApa()
        {
            energie += 5;
            foame += 5;
            fericire += 5;
            sete -= 30;
            greutate += 0.05m;
            sanatate += 2;
            if (sete <= 20)
            {
                Console.WriteLine($"{ IntroducereSexAnimal.gender} are nevoie de apa");
            }
            if(foame >= 70)
            {
                Console.WriteLine("mi fomita");
            }
            if (greutate >= 3.00m)
            {
                Console.WriteLine($"{IntroducereSexAnimal.gender} a depasit 3kg. ai grija ");
            }
            if(sete <= 20)
            {
                Console.WriteLine("am baut destula apa");
            }

        }

        public void Joaca()
        {
            energie -= 20;
            foame += 20;
            fericire += 20;
            sete += 20;
            greutate -= 0.20m;
            sanatate += 3;
            if (energie <= 20)
            {
                Console.WriteLine($"{IntroducereSexAnimal.gender} a atins pragul de 20% energie. be sure to rest.");
            }
            if (sete >= 80)
            {
                Console.WriteLine($"{ IntroducereSexAnimal.gender} a cam baut apa...");
            }
            if(foame >= 70)
            {
                Console.WriteLine("mi fomita");
            }            
        }

        public void Doarme()
        {
            energie += 40;
            foame += 10;
            fericire += 10;
            sete += 20;
            sanatate += 5;
            if (sete <= 20)
            {
                Console.WriteLine($"{ IntroducereSexAnimal.gender} are nevoie de apa");
            }
            if(energie >= 100)
            {
                Console.WriteLine($"{IntroducereSexAnimal.gender} a dormit prea mult. descarca din energie");
            }
            if (foame >= 70)
            {
                Console.WriteLine("mi fomita");
            }
        }

        public void PisicaGrasa()
        {
            sanatate -= 20;
            energie -= 20;            
            if(sanatate <= 10)
            {
                Console.WriteLine("Atentie! sanatatea a scazut la 10. mergi la veterinar.");
            }
            if(energie <= 10)
            {
                Console.WriteLine("ar prinde bine un pui de somn. pt energie");
            }
        }

        public void PisicaSomnoroasa()
        {
            sanatate -= 20;
            foame -= 20;
            sete += 20;
            if(sanatate <= 10)
            {
                Console.WriteLine("Atentie! sanatatea a scazut la 10. mergi la veterinar.");
            }
            if (sete <= 20)
            {
                Console.WriteLine($"{ IntroducereSexAnimal.gender} are nevoie de apa");
            }

        }    
             
        public void Medic()
        {
            energie = 20;
            foame = 60;
            fericire = 40;
            sete = 80;
            sanatate = 99;
        }
    }
}