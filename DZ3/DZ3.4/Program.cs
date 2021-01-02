using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] seaBattle = new string[10, 10];

            for (int i = 0; i < seaBattle.GetLength(0); i++)
            {
                for (int j = 0; j < seaBattle.GetLength(1); j++)
                {
                    if ((i == 0) || (i % 2 == 0))
                    {
                        if ((j == 0) || (j % 2 == 0))
                            seaBattle[i, j] = "X";
                        else
                            seaBattle[i, j] = "O";
                    }
                    else
                    {
                        if ((j == 0) || (j % 2 == 0))
                            seaBattle[i, j] = "O";
                        else
                            seaBattle[i, j] = "X";
                    }
                }
            }

                for (int i = 0; i < seaBattle.GetLength(0); i++)
                {
                    for (int j = 0; j < seaBattle.GetLength(1); j++)
                    {
                        Console.Write(seaBattle[i,j] + " ");
                    }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
