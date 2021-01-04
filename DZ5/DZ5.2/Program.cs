using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "startup.txt";

            File.WriteAllText(fileName, DateTime.Now.ToShortTimeString());
        }
    }
}
