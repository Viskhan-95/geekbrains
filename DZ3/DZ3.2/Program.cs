using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phonebook = new string[5, 2];

            for (int i = 0; i < phonebook.GetLength(0); i++)
            {
                Console.Write("Введите имя контакта: ");
                phonebook[i, 0] = Console.ReadLine();

                Console.Write("Введите номер контакта: ");
                phonebook[i, 1] = Console.ReadLine();
            }

            for (int i = 0; i < phonebook.GetLength(0); i++)
            {
                for (int j = 0; j < phonebook.GetLength(1); j++)
                {
                    Console.Write(phonebook[i,j]);
                    Console.WriteLine();
                }

            }
            Console.ReadKey();
        }
    }
}
