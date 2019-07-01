using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermaAnimalelor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intr-o ferma se afla 3 vaci, 2 oi si 5 gaini. Defineste clasele corespunzatoare
            //folosind clasele si interfetele predefinite fara a le modifica in vreun fel si 
            // afiseaza raspunsurile la cele 4 intrebari de mai jos.

            //adauga animalele in lista predefinita
            var animale = new Animal[10];
                       

            var vaca = new Vaca();
            var vaca2 = new Vaca();
            var vaca3 = new Vaca();
            var oaie = new Oaie();
            var oaie2 = new Oaie();
            var gaina = new Gaina();
            var gaina2 = new Gaina();
            var gaina3 = new Gaina();
            var gaina4 = new Gaina();
            var gaina5 = new Gaina();

            animale[0] = vaca;
            animale[1] = vaca2;
            animale[2] = vaca3;
            animale[3] = oaie;
            animale[4] = oaie2;
            animale[5] = gaina;
            animale[6] = gaina2;
            animale[7] = gaina3;
            animale[8] = gaina4;
            animale[9] = gaina5;


            int countGaini = 0;

            foreach (var item in animale)
            {
                if (item.Rasa == "gaina")   // count
                {
                    countGaini++;
                }
            }

            Console.WriteLine($"Numarul de gaini este: { countGaini}");

            foreach (var animal in animale)
            {
                for (int i = 0; i < animal.HranaPreferata.Length; i++)  // foreach e blana
                {
                    animal.Mananca(animal.HranaPreferata[i]);
                }                
                
            }

            int numarResurseVaca = 0;
            int numarResurseOaie = 0;
            int numarResurseGaina = 0;

            

            foreach (var animal in animale)
            {                
                var resursa = animal.ColecteazaResurse();

                if(animal.Rasa == "vaca")
                {
                    numarResurseVaca += resursa.Cantitate ;
                }

                if(animal.Rasa == "oaie")
                {
                    numarResurseOaie += resursa.Cantitate;
                }

                if(animal.Rasa == "gaina")
                {
                    numarResurseGaina += resursa.Cantitate;
                }

            }          
            

            Console.WriteLine(numarResurseVaca);
            Console.WriteLine(numarResurseOaie);
            Console.WriteLine(numarResurseGaina);

            foreach (var animal in animale)
            {
                if(animal.Rasa == "vaca")
                {
                    foreach (var food in animal.HranaPreferata)
                    {
                        animal.Mananca(food);    // vorbeam de blana
                    }                    
                    animal.Doarme();
                }

                if (animal.Rasa == "oaie")
                {
                    foreach (var food in animal.HranaPreferata)
                    {
                        animal.Mananca(food);
                    }
                    animal.Doarme();
                }

                if (animal.Rasa == "gaina") 
                {
                    foreach (var food in animal.HranaPreferata)
                    {
                        animal.Mananca(food);
                    }
                    animal.Doarme();
                }
            }

            foreach (var animal in animale)
            {
                Console.WriteLine(animal.AnimalAdormit);
            }

            Adapost adapostMic = new Adapost();
            Adapost adapostMare = new Adapost();

            foreach (var animal in animale)
            {                               

                animal.Adapostire();

                if(animal.AnimalAdapostit == true)
                {
                    if(animal.NumarPicioare == 2 )
                    {
                        adapostMic.EnterAdapost();
                    }
                    if(animal.NumarPicioare == 4)
                    {
                        adapostMare.EnterAdapost();
                    }
                }                                
            }

            adapostMare.Afisare();
            adapostMic.Afisare();          
            
            

            //1. Tipareste numarul de gaini calculandul programatic


            //2. Hraneste animalele cu tipul de hrana adecvat. Tipurile de hrana vor fi definite
            // folosind IHRana si create in folderul Hrana


            //3. Colecteaza toate resursele produse de animale (oua, lapte) si afisati totalul cantitatii
            //   colectate pentru fiecare din ele.
            //   Tipurile de resurse vor fi definite folosind IResursa si vor fi puse in folderul
            //   Resurse


            //4. Pune animalele la somn. Pentru a ne asigura ca animalele sunt la somn se va 
            // verifica ca fiecare Animal este "AnimalAdormit"- proprietate disponibila pe clasa 
            // animal. 

            Console.ReadLine();
        }
    }
}