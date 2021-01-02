using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальную суточную температуру: ");
            double maxTemp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите минимальную суточную температуру: ");
            double minTemp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Среднесуточная температура равна " + ((maxTemp + minTemp)/2).ToString("0.00"));

            Console.ReadKey();
        }
    }
}
