using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                AddNewDataUser();
            }

            Console.WriteLine($"{Properties.Settings.Default?.greeting} {Properties.Settings.Default.UserName}. \nВам {Properties.Settings.Default.Age}. \nРод вашей деятельности: {Properties.Settings.Default.Work}");
           
            Console.ReadKey();
        }

        static void AddNewDataUser()
        {
            Console.Write("Введите имя пользователя: ");
            Properties.Settings.Default.UserName = Console.ReadLine();
            Properties.Settings.Default.Save();

            Console.Write("Введите род деятельности пользователя: ");
            Properties.Settings.Default.Work = Console.ReadLine();
            Properties.Settings.Default.Save();

            Console.Write("Введите возраст пользователя: ");
            Properties.Settings.Default.Age = Convert.ToInt32(Console.ReadLine());
            Properties.Settings.Default.Save();
        }
    }
}
