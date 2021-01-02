using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Пиивет, {name}, сегодня {DateTime.Now.ToString("dd.MM.yyyy")}");

            Console.ReadKey();
        }
    }
}
