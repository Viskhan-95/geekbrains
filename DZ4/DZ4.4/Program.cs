using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetFibonacci(number));
            Console.ReadKey();
        }

        static int GetFibonacci(int number)
        {
            if(number == 0 || number == 1)
            {
                return number;
            }
            return GetFibonacci(number-1) + GetFibonacci(number - 2);
        }
    }
}
