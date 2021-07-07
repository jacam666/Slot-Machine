using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;

namespace Slot_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] gridNumbers = gridNumberGenerator();
            gridResult(gridNumbers);

        }

        private static int[,] gridNumberGenerator()
        {
            int[,] gridNumbers = new int[3, 3];
            Random rng = new();
            for (int i = 0; i < gridNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < gridNumbers.GetLength(1); j++)
                {
                    gridNumbers[i, j] = rng.Next(0, 9);
                    Console.Write(gridNumbers[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            return gridNumbers;
        }

        private static void gridResult(int[,] gridNumbers)
        {
            if ((gridNumbers[0, 0]) == (gridNumbers[0, 1]) && (gridNumbers[0, 1]) == (gridNumbers[0, 2]))
            {
                Console.WriteLine("Congrats you win");
            }
            if ((gridNumbers[1, 0]) == (gridNumbers[1, 1]) && (gridNumbers[1, 1]) == (gridNumbers[1, 2]))
            {
                Console.WriteLine("Congrats you win");
            }
            if ((gridNumbers[2, 0]) == (gridNumbers[2, 1]) && (gridNumbers[2, 1]) == (gridNumbers[2, 2]))
            {
                Console.WriteLine("Congrats you win");
            }
        }

    }
}

















































































