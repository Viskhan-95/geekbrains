using System;
using System.IO;
using System.Text.Json;

namespace DZ5._5
{
    class Program
    {
        static void Main(string[] args) //Хотелось бы это задание решить совместно, для меня трудная задача на данный момент
        {
            int count = 1;
            if (File.Exists("tasks.json"))
            {
                string toDoStr = File.ReadAllText("tasks.json");
                var toDo1 = JsonSerializer.Deserialize<ToDo>(toDoStr);
                Console.Write($"{toDo1.Number} ");
                Console.WriteLine(toDo1.Title);
                count = toDo1.Number + 1;
            }

            ToDo toDo = new ToDo();
            Console.Write("Задача: ");
            toDo.Title = Console.ReadLine();
            toDo.Number = count;
            toDo.IsDone = false;

            string json = JsonSerializer.Serialize(toDo);
            File.AppendAllText("tasks.json", json);

            Console.ReadKey();
        }
    }
}
