using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string lastName = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вывести ваши данные на экран?");
            string answerUser = Console.ReadLine();

            if (answerUser.ToLower() == "да")
            {
                Console.WriteLine($"Вас зовут {lastName}. Вам {age} лет.");
            }
            else
                Console.WriteLine("Спасибо!");
        }
    }
}
