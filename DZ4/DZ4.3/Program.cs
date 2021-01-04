using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMоnth;
            do
            {
                Console.Write("Введите порядковый номер месяца: ");
                numberMоnth = ReadInt();

                if (numberMоnth > 12 || numberMоnth < 1)
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                }
            } while (numberMоnth > 12 || numberMоnth < 1);

            Seasons seasons = NumberMonth(numberMоnth);
            string seasonsRus = SeasonsRus(seasons);

            Console.WriteLine(seasonsRus);
            Console.ReadKey();
        }

        static Seasons NumberMonth(int numberMоnth)
        {
            Seasons seasons = new Seasons();

            if (numberMоnth == 1 || numberMоnth == 2 || numberMоnth == 12)
                seasons = Seasons.Winter;

            else if (numberMоnth == 3 || numberMоnth == 4 || numberMоnth == 5)
                seasons = Seasons.Spring;

            else if (numberMоnth == 6 || numberMоnth == 7 || numberMоnth == 8)
                seasons = Seasons.Summer;

            else if (numberMоnth == 9 || numberMоnth == 10 || numberMоnth == 11)
                seasons = Seasons.Autumn;

            return seasons;
        }

        static string SeasonsRus(Seasons seasons)
        {
            string seasonsRus = string.Empty;

            switch (seasons.ToString())
            {
                case "Winter":
                    seasonsRus = "Зима";
                    break;
                case "Spring":
                    seasonsRus = "Весна";
                    break;
                case "Summer":
                    seasonsRus = "Лето";
                    break;
                case "Autumn":
                    seasonsRus = "Осень";
                    break;
            }
            return seasonsRus;
        }

        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
