using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3foldereMONITOR
{
    public class MonitorizareRename
    {
        public static void EvenimenteRename()
        {
            FileSystemWatcher Folder1 = new FileSystemWatcher();
            Folder1.Path = "D:\\SHARP1";

            FileSystemWatcher Folder2 = new FileSystemWatcher();
            Folder2.Path = "D:\\SHARP2";

            FileSystemWatcher Folder3 = new FileSystemWatcher();
            Folder3.Path = "D:\\SHARP3";

            Folder1.Renamed += Folder1_Renamed;
            Folder2.Renamed += Folder2_Renamed;
            Folder3.Renamed += Folder3_Renamed;

            Folder1.EnableRaisingEvents = true;
            Folder2.EnableRaisingEvents = true;
            Folder3.EnableRaisingEvents = true;
        }

        private static void Folder3_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Fisierul {e.OldName} a fost redenumit in {e.Name} in locatia {e.FullPath}");
        }

        private static void Folder2_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Fisierul {e.OldName} a fost redenumit in {e.Name} in locatia {e.FullPath}");
        }

        private static void Folder1_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Fisierul {e.OldName} a fost redenumit in {e.Name} in locatia {e.FullPath}");
        }
    }
}