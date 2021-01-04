using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DZ5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа от 0 до 255: ");

            byte[] binary = System.Text.Encoding.UTF8.GetBytes(Console.ReadLine());

            string fileName = "binaryFile.bin";
            //string fileName = "binaryFile.txt";

            File.WriteAllBytes(fileName, binary);

            Console.ReadKey();
        }
    }
}
