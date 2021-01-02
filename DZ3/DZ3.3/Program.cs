using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово: ");
            string getString = Console.ReadLine();
            string revers = string.Empty;

            for (int i = getString.Length-1; i >= 0; i--)
            {
                revers += getString[i];

            }
            Console.WriteLine(revers);
            Console.ReadKey();
        }
    }
}
