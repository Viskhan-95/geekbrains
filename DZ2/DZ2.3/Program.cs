using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
                Console.WriteLine("На ноль нельзя делить");
            else if (num % 2 == 0)
                Console.WriteLine("Введенное число является четным");
            else
                Console.WriteLine("Введенное число является нечетным");

            Console.ReadKey();
        }
    }
}
