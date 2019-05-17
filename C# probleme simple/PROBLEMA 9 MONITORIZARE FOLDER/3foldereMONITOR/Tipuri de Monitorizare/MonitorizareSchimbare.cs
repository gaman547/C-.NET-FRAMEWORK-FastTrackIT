using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3foldereMONITOR
{
    public class MonitorizareSchimbare
    {
        public static void EvenimenteSchimbare()
        {
            FileSystemWatcher Folder1 = new FileSystemWatcher();
            Folder1.Path = "D:\\SHARP1";

            FileSystemWatcher Folder2 = new FileSystemWatcher();
            Folder2.Path = "D:\\SHARP2";

            FileSystemWatcher Folder3 = new FileSystemWatcher();
            Folder3.Path = "D:\\SHARP3";

            Folder1.Changed += Folder1_Changed;
            Folder2.Changed += Folder2_Changed; 
            Folder3.Changed += Folder3_Changed;

            Folder1.EnableRaisingEvents = true;
            Folder2.EnableRaisingEvents = true;
            Folder3.EnableRaisingEvents = true;
        }

        private static void Folder3_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Tipul fisierului {e.Name} a fost modificat ({e.ChangeType}) in locatia {e.FullPath}");
        }

        private static void Folder2_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Tipul fisierului {e.Name} a fost modificat ({e.ChangeType}) in locatia {e.FullPath}");
        }

        private static void Folder1_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Tipul fisierului {e.Name} a fost modificat ({e.ChangeType}) in locatia {e.FullPath}");
        }
    }
}