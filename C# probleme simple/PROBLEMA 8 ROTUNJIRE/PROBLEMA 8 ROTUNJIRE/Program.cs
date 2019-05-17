using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_8_ROTUNJIRE
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroDate();
            Console.ReadKey();
        }

        static int NumarStudenti;
        static void IntroDate()
        {
              Console.WriteLine(@"                       Bine ai venit Mihai! Acest program rotunjeste notele studentilor dupa cum urmeaza:
          Daca diferenta dintre nota si urmatorul multitplu de 5 este mai mica decat 3 atunci rotunjeste la 
          urmatorul multiplu de 5. Daca nota este mai mica decat 38 atunci nu se aplica nici o rotunjire 
          deoarece nu mai este nota de trecere.");
              Console.WriteLine();

              Console.Write("Numarul de studenti care au sustinut examenul: ");
          NumarStudenti = Convert.ToInt32(Console.ReadLine());

              int[] note = new int[NumarStudenti];

              for (int i = 0; i < NumarStudenti; i++)
              {
                   note[i] = Convert.ToInt32(Console.ReadLine());
                   if(note[i] < 0 || note[i] > 100)
                   {
                       Console.WriteLine();
                       Console.ForegroundColor = ConsoleColor.DarkRed;
                       Console.WriteLine("MIHAI! Atentie! Studentii sunt notati de la 0 la 100. Apasa orice tasta pentru a continua.");
                       Console.ResetColor();
                       Console.ReadKey();
                       System.Environment.Exit(0);
                   }
              }

              Console.WriteLine();
              Console.Write("Notele sunt modificate dupa cum urmeaza: ");
              Console.WriteLine(); 
 
              for (int i = 0; i < NumarStudenti; i++)
              {
                   if(note[i] >= 38)
                   {
                       if((note[i] + 2) % 5 == 0)
                       {
                           note[i] = note[i] + 2;
                       }
                       else if((note[i] + 1) % 5 == 0 )
                       {
                           note[i] = note[i] + 1; 
                       }
                   }
              }

            for (int i = 0; i < NumarStudenti; i++)
            {
                Console.WriteLine(note[i]);
            }
        }      
    }
}