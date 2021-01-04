using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();

            foreach (var proc in processes)
            {
                Console.WriteLine($"ID - {proc.Id} \t Name - {proc.ProcessName}");
            }

            Console.Write("Для завершения процесса введите название или ID процесса: ");

            string enterData = Console.ReadLine();

            bool stringOrInt = StringOrInt(enterData);

            if (stringOrInt)
                KillProcByiD(Convert.ToInt32(enterData));
            else
                KillProcByName(enterData);

            Console.ReadKey();
        }

        static bool StringOrInt(string checkStr)
        {
            bool isNumeric = int.TryParse(checkStr, out int numeric);
            return isNumeric;
        }

        static void KillProcByName(string procName)
        {
            Process[] processes = Process.GetProcesses();

            bool isProcess = false;
            foreach(var proc in processes)
            {
                if (procName == proc.ProcessName)
                {
                    proc.Kill();
                    isProcess = true;
                }
            }
            if (!isProcess)
                Console.WriteLine("Вы ввели неправильное имя процесса. Введите правильное имя");
        }

        static void KillProcByiD(int prociD)
        {
            Process[] processes = Process.GetProcesses();
            bool isProcess = false;

            foreach (var proc in processes)
            {
                if (prociD == proc.Id)
                {
                    proc.Kill();
                    isProcess = true;
                }
            }
            if (!isProcess)
                Console.WriteLine("Вы ввели неправильное ID процесса. Введите правильное ID");
        }
    }
}
