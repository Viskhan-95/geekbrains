using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    class Program
    {
        static string[] dataUsers;
        
        static void Main(string[] args)
        {
            BaseUser();
            OutputDataUsers();

            Console.ReadKey();
        }

        static void BaseUser()
        {
            Console.Write("Введите количество пользователей: ");
            int cointUser = ReadInt();

            dataUsers = new string[cointUser];

            for (int i = 0; i < dataUsers.Length; i++)
            {
                dataUsers[i] = DataUser();
            }            

        }

        static string DataUser()
        {
            Console.Write("Введите фамилию пользователя: ");
            string firstName = Console.ReadLine();

            Console.Write("Введите имя пользователя: ");
            string lasttName = Console.ReadLine();

            Console.Write("Введите отчество пользователя: ");
            string patronymic = Console.ReadLine();

            string dataUser = GetFullName(firstName, lasttName, patronymic);

            return dataUser;
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {lastName} {patronymic}";
        }

        static void OutputDataUsers()
        {
            for (int i =0; i < dataUsers.Length; i++)
            {
                Console.WriteLine($"{dataUsers[i]} \t");
            }
        }

        static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
