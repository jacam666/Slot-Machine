using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    static class UI
    {

        public static double DisplayWelcomeScreenGetCashValue()
        {
            string playerName;
            string response;
            Console.Write("Please Enter Player's Name: ");
            playerName = Console.ReadLine();
            Console.WriteLine($"Welcome to my slot game {playerName} ");
            Console.Write("Amount of Cash you would like to use in the slots: £");
            response = Console.ReadLine();
            double cash = Convert.ToDouble(response);
            return cash;

        }

        public static void DisplayCurrentCash(double cash)
        {
            Console.WriteLine($"Cash = £{cash}");
        }

        public static void DisplayCurrentSlotGrid(int[,] grid)
        {

            //TODO: implement that already 

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    //grid[i, j] = rng.Next(0, 3);
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
        public static bool DecisionToPlay()
        {
            string response;
            bool wantsToPlay = false;
            Console.WriteLine("Play Slots? y/n");
            response = Console.ReadLine();
            if (response == "y")
            {
                wantsToPlay = true;               
            }
            return wantsToPlay;

        }
      
    }
}
