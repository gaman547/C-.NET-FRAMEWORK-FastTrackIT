using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3foldereMONITOR
{
    public class MonitorizareCreare
    {
        public static void EvenimenteCreare()
        {
            FileSystemWatcher Folder1 = new FileSystemWatcher();
            Folder1.Path = "D:\\SHARP1";

            FileSystemWatcher Folder2 = new FileSystemWatcher();
            Folder2.Path = "D:\\SHARP2";

            FileSystemWatcher Folder3 = new FileSystemWatcher();
            Folder3.Path = "D:\\SHARP3";

            Folder1.Created += Folder1_Created;
            Folder2.Created += Folder2_Created; 
            Folder3.Created += Folder3_Created;                      
           
            Folder1.EnableRaisingEvents = true;
            Folder2.EnableRaisingEvents = true; 
            Folder3.EnableRaisingEvents = true;
        }

        private static void Folder3_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Fisierul {e.Name} a fost creat in locatia {e.FullPath}");
        }

        private static void Folder2_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Fisierul {e.Name} a fost creat in locatia {e.FullPath}");
        }

        private static void Folder1_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Fisierul {e.Name} a fost creat in locatia {e.FullPath}");
        }
    }
}