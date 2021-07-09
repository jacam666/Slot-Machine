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
            int[,] gridNumbers = GridNumberGenerator();
            GridResult(gridNumbers);

        }

        private static int[,] GridNumberGenerator()
        {
            int[,] gridNumbers = new int[3, 3];
            Random rng = new();
            for (int i = 0; i < gridNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < gridNumbers.GetLength(1); j++)
                {
                    gridNumbers[i, j] = rng.Next(0, 3);
                    Console.Write(gridNumbers[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            return gridNumbers;
        }

        private static void GridResult(int[,] gridNumbers)
        {// matching vertical lines
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

            // matching vertical lines
            if ((gridNumbers[0,0]) == (gridNumbers[1,0]) && (gridNumbers[1,0]) == (gridNumbers[2,0]))
            {
                Console.WriteLine("congrats you win");
            }
            if ((gridNumbers[0,1]) == (gridNumbers[1,1]) && (gridNumbers[1,1]) == (gridNumbers[2,1]))
            {
                Console.WriteLine("Congrats you win");
            }
            if ((gridNumbers[0,2]) == (gridNumbers[1,2]) && (gridNumbers[1,2]) == (gridNumbers[2,2]))
            {
                Console.WriteLine("Congrats you win");
            }
            // matching diagonal lines
            if ((gridNumbers[0,0]) == (gridNumbers[1,1]) && (gridNumbers[1,1]) == (gridNumbers[2,2]))
            {
                Console.WriteLine("Congrats you win");
            }
            if ((gridNumbers[0,2]) == (gridNumbers[1,1]) && (gridNumbers[1,1]) == (gridNumbers[2,0]))
            {
                Console.WriteLine("Congrats you win");
            }
                
                
        }

    }
}

















































































