using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordine_crescatoare
{
    public class BubbleSort
    {
        public static void SortareBubble()
        {
            int temp;

            for (int i = 0; i <  Program.numere.Length; i++)
            {
                for (int j = Program.numere.Length - 1; j > i; j--)
                {
                    if (Program.numere[j] < Program.numere[j - 1])
                    {
                        temp = Program.numere[j];
                        Program.numere[j] = Program.numere[j - 1];
                        Program.numere[j - 1] = temp;
                    }
                }
            }

            Console.WriteLine("Ordine crescatoare:");
            foreach (int item in Program.numere)
                Console.Write(item + " ");
        }
    }
}