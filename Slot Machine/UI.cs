using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    static class UI
    {

        public static void DisplayWelcomeScreen()
        {
            string playerName;
            Console.Write("Please Enter Player's Name: ");
            playerName = Console.ReadLine();
            Console.WriteLine($"Welcome to my slot game {playerName} ");
            Console.Write("Amount of Cash you would like to use in the slots: £");
        }
        public static void DisplayCurrentSlotGrid(int[,] grid)
        {
            grid = new int[3, 3];
            Random rng = new();
            //TODO: implement that already 

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = rng.Next(0, 3);
                    Console.Write(grid[i, j] + " ");

                }
                Console.WriteLine(" ");
            }
        }
        /// <summary>
        /// informs player if they win and how much
        /// </summary>
        /// <param name="amount"></param>
        public static void DisplayWinInfo(int amount)
        {
            if (amount > 0)
                Console.WriteLine($"You win!! £{amount}");
               
        }
        /// <summary>
        /// when player runs out of cash
        /// </summary>
        public static void OutOfFunds()

        {
            {
                Console.WriteLine("You are out of cash. Game over.");
                Console.Read();

            }
        }
        /// <summary>
        /// players decision to play again
        /// </summary>
        public static void DecisionToPlay()
        {
            Console.WriteLine("Play Slots? y/n");
        }

        //public static void CashAvailable()
        //{

        //    Console.WriteLine($"Cash = £");
        //}
        //public static int CalculateGridWinnings(int amount, int[,] grid)
        //{
        //    int cash;
        //    for (int i = 0; i < grid.GetLength(0); i++) //on a 3x3 grid, this runs 3 times
        //    {
        //        if (grid[i, 0] == grid[i, 1] && grid[i, 1] == grid[i, 2])  //horizontal lines                                            
        //            if (grid[0, i] == grid[1, i] && grid[1, i] == grid[2, i]) //vertical lines
        //            {
        //                UI.DisplayWinInfo(amount);
        //            }
        //    }

        //    if ((grid[0, 0]) == (grid[1, 1]) && (grid[1, 1]) == (grid[2, 2])) // diagonal lines

        //        if ((grid[0, 2]) == (grid[1, 1]) && (grid[1, 1]) == (grid[2, 0]))  // diagonal lines
        //        {
        //            UI.DisplayWinInfo(amount);
        //        }
        //    return amount;
        //}
    }
}
