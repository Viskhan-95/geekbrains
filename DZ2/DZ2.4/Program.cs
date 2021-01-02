using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишите название месяця: ");
            string month = Console.ReadLine().ToLower();

            Console.Write("Укажите среднюю температуру дня: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            string season = string.Empty;

            switch (month)
            {
                case "декабрь":
                case "январь":
                case "февраль":
                    season = "зима";
                    break;

                case "март":
                case "апрель":
                case "май":
                    season = "весна";
                    break;

                case "июнь":
                case "июль":
                case "август":
                    season = "лето";
                    break;

                case "сентябрь":
                case "октябрь":
                case "ноябрь":
                    season = "зима";
                    break;

                default:
                    Console.WriteLine("Не правильный выбор. Выберите месяц года");
                    break;
            }

            if ((season == "зима") && (temp > 0))
                    Console.WriteLine("Дождливая зима");

            Console.ReadKey();
        }
    }
}
