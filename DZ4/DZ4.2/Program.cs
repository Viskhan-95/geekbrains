using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку из чисел через пробел: ");
            string integerString = Console.ReadLine();

            int sum = ConverterStrintToInt(integerString);

            Console.WriteLine(sum);
            Console.ReadKey();
        }

        static int ConverterStrintToInt(string integerString)
        {
            int sum = 0;
            string[] str = integerString.Split(' ');

            foreach(var s in str)
            {
                sum += Convert.ToInt32(s);
            }

            return sum;
        }
    }
}
