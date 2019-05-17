using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3foldereMONITOR
{
    public class MonitorizareStergere
    {
        public static void EvenimenteStergere()
        {
            FileSystemWatcher Folder1 = new FileSystemWatcher();
            Folder1.Path = "D:\\SHARP1";

            FileSystemWatcher Folder2 = new FileSystemWatcher();
            Folder2.Path = "D:\\SHARP2";

            FileSystemWatcher Folder3 = new FileSystemWatcher();
            Folder3.Path = "D:\\SHARP3";

            Folder1.Deleted += Folder1_Deleted;
            Folder2.Deleted += Folder2_Deleted;
            Folder3.Deleted += Folder3_Deleted;

            Folder1.EnableRaisingEvents = true;
            Folder2.EnableRaisingEvents = true;
            Folder3.EnableRaisingEvents = true;
        }

        private static void Folder3_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Fisierul {e.Name} a fost sters din locatia {e.FullPath}");
        }

        private static void Folder2_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Fisierul {e.Name} a fost sters din locatia {e.FullPath}");
        }

        private static void Folder1_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Fisierul {e.Name} a fost sters din locatia {e.FullPath}");
        }
    }
}