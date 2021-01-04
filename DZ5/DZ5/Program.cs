using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку для сохранения: ");

            string strData = Console.ReadLine();

            AddStringToFile(strData);

            Console.ReadKey();
        }

        static void AddStringToFile(string strData)
        {
            string fileName = "text.txt";            

            File.AppendAllText(fileName, strData);
        }
    }
}
