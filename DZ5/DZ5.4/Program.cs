using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Intel";

            //Console.WriteLine(Directory.Exists(path));

            foreach(var dir in Directory.GetFileSystemEntries(path, "*", SearchOption.AllDirectories))
            {
                File.AppendAllText("DirTree.txt", $"{ dir} \n");
            }

            PrintDirTree(path);
            Console.ReadKey();
        }


        static void PrintDirTree(string dirName) 
        {
            if (!Directory.Exists(dirName))
            {
                File.AppendAllText("DirTree.txt", $"{ dirName} \n"); // В этом методе не могу понять почему выводит файлы 2 раза, а если не указать этот фрагмент, то не выводит файлы
                return;
            }
            File.AppendAllText("DirTree.txt", $"{ dirName} \n");

            foreach (var dir in Directory.GetFileSystemEntries(dirName, "*", SearchOption.AllDirectories))
            { 
                PrintDirTree(dir);
            }
        }
    }
}
