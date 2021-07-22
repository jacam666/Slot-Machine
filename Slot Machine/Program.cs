﻿using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;

namespace Slot_Machine
{
    class Program
    {
        private static int[,] grid;

        static void Main(string[] args)
        {
            UI.DisplayWelcomeScreen();
            double cash = Convert.ToDouble(Console.ReadLine());
            string response;
            

            for (; ; ) // Loop forever
            {
                if (cash <= 0)
                {
                    UI.OutOfFunds();
                    break;
                }

                Console.WriteLine($"Cash = £{cash}");
                UI.DecisionToPlay();
                response = Console.ReadLine();

                if (response == "n")
                {
                    break;
                }

                cash -= 1;
                int[,] gridNumbers = new int[3, 3];
                if (cash > 0)                
                    UI.DisplayCurrentSlotGrid(gridNumbers);
                    CalculateGridWinnings(gridNumbers);              
            }           
        }
        /// <summary>
        /// Returns amount of cash won for a particular reel
        /// </summary>
        /// <param name="grid">the gird to check</param>
        /// <returns>the won amount</returns>
        static int CalculateGridWinnings(int[,] grid)
        {
            int cash = 0;
            
            for (int i = 0; i < grid.GetLength(0); i++) //on a 3x3 grid, this runs 3 times
            {
                if (grid[i, 0] == grid[i, 1] && grid[i, 1] == grid[i, 2])  //horizontal lines
                {
                    UI.DisplayWinInfo(cash);
                    //UI.WinningsPerReel(amount);
                    //cash += 2;
                }
                if (grid[0, i] == grid[1, i] && grid[1, i] == grid[2, i]) //vertical lines
                {
                    UI.DisplayWinInfo(cash);
                    //UI.WinningsPerReel(amount);
                    //cash += 2;
                }
            }

            if ((grid[0, 0]) == (grid[1, 1]) && (grid[1, 1]) == (grid[2, 2])) // diagonal lines
            {
                UI.DisplayWinInfo(cash);
                //UI.WinningsPerReel(amount);
                //cash += 2;
            }

            if ((grid[0, 2]) == (grid[1, 1]) && (grid[1, 1]) == (grid[2, 0])) // diagonal lines
            {
                UI.DisplayWinInfo(cash);
                //UI.WinningsPerReel(amount);
                //cash += 2;
            }
            
            return cash;
        }


        /// old code
        /////
        //static void GridResult(int[,] gridNumbers)
        //{    // matching vertical line.

        //    for (int i = 0; i < gridNumbers.GetLength(0); i++)
        //    {
        //        if (gridNumbers[i, 0] == gridNumbers[i, 1] && gridNumbers[i, 1] == gridNumbers[i, 2])
        //        {
        //            Console.WriteLine("you win");
        //        }
        //        if (gridNumbers[0, i] == gridNumbers[1, i] && gridNumbers[1, i] == gridNumbers[2, i])
        //        {
        //            Console.WriteLine("you win");
        //        }
        //    }

        //}

        //for (int i = 0; i < gridNumbers.GetLength(0); i++) ;
        //{
        //    if (gridNumbers[i, 0] == gridNumbers[i, 1] && gridNumbers[i, 1] == gridNumbers[i, 2])  //horizontal lines
        //    {
        //        Console.WriteLine("you win");
        //        cash += 2;
        //    }
        //    if (gridNumbers[0, i] == gridNumbers[1, i] && gridNumbers[1, i] == gridNumbers[2, i]) //vertical lines
        //    {
        //        Console.WriteLine("you win");
        //        cash += 2;
        //    }
        //}
        //// adding diagonal winning lines.

        //if ((gridNumbers[0, 0]) == (gridNumbers[1, 1]) && (gridNumbers[1, 1]) == (gridNumbers[2, 2]))
        //{
        //    Console.WriteLine("Congrats You Win");
        //    cash += 5;
        //}
        //if ((gridNumbers[0, 2]) == (gridNumbers[1, 1]) && (gridNumbers[1, 1]) == (gridNumbers[2, 0]))
        //{
        //    Console.WriteLine("Congrats You Win");
        //    cash += 5;
        //}

        //old code here:

        //int verticlReel1 = gridNumbers[0, 0] + gridNumbers[0, 1] + gridNumbers[0, 2];
        //int verticlReel2 = gridNumbers[1, 0] + gridNumbers[1, 1] + gridNumbers[1, 2];
        //int verticlReel3 = gridNumbers[2, 0] + gridNumbers[2, 1] + gridNumbers[2, 2];

        //int horizontalReel1 = gridNumbers[0, 0] + gridNumbers[1, 0] + gridNumbers[2, 0];
        //int horizontalReel2 = gridNumbers[0, 1] + gridNumbers[1, 1] + gridNumbers[2, 1];
        //int horizontalReel3 = gridNumbers[0, 2] + gridNumbers[1, 2] + gridNumbers[2, 2];

        //int diadonalReel1 = gridNumbers[0, 0] + gridNumbers[1, 1] + gridNumbers[2, 2];
        //int diagonalReel3 = gridNumbers[2, 0] + gridNumbers[1, 5] + gridNumbers[0, 3];

        //if ((gridNumbers[0, 0]) == (gridNumbers[0, 1]) && (gridNumbers[0, 1]) == (gridNumbers[0, 2]))
        //{
        //    Console.WriteLine("Congrats You Win");
        //}
        //if ((gridNumbers[1, 0]) == (gridNumbers[1, 1]) && (gridNumbers[1, 1]) == (gridNumbers[1, 2]))
        //{
        //    Console.WriteLine("Congrats You Win");
        //}
        //if ((gridNumbers[2, 0]) == (gridNumbers[2, 1]) && (gridNumbers[2, 1]) == (gridNumbers[2, 2]))
        //{
        //    Console.WriteLine("Congrats You Win");
        //}

        //// matching vertical lines
        //if ((gridNumbers[0, 0]) == (gridNumbers[1, 0]) && (gridNumbers[1, 0]) == (gridNumbers[2, 0]))
        //{
        //    Console.WriteLine("congrats You Win");
        //}
        //if ((gridNumbers[0, 1]) == (gridNumbers[1, 1]) && (gridNumbers[1, 1]) == (gridNumbers[2, 1]))
        //{
        //    Console.WriteLine("Congrats You Win");
        //}
        //if ((gridNumbers[0, 2]) == (gridNumbers[1, 2]) && (gridNumbers[1, 2]) == (gridNumbers[2, 2]))
        //{
        //    Console.WriteLine("Congrats You Win");
        //}
        //// matching diagonal lines
        //if ((gridNumbers[0, 0]) == (gridNumbers[1, 1]) && (gridNumbers[1, 1]) == (gridNumbers[2, 2]))
        //{
        //    Console.WriteLine("Congrats You Win");
        //}
        //if ((gridNumbers[0, 2]) == (gridNumbers[1, 1]) && (gridNumbers[1, 1]) == (gridNumbers[2, 0]))
        //{
        //    Console.WriteLine("Congrats You Win");
        //}

        //}
        //for (; ; ) // Loop forever
        //{
        //    if (cash <= 0)
        //    {
        //        Console.WriteLine("You are out of cash. Game over.");
        //        Console.Read();
        //        break;
        //    }
        //    Console.WriteLine("Cash = {0}", cash);
        //    Console.WriteLine("Play Slots? y/n");
        //    response = Console.ReadLine();


        //}

        //    static void Main(string[] args)
        //    {
        //        string playerName;
        //        Console.Write("Please Enter Player's Name: ");
        //        playerName = Console.ReadLine();
        //        Console.WriteLine($"Welcome " +  playerName + " to my slot game");

        //        int[,] gridNumbers = GridNumberGenerator();
        //        GridResult(gridNumbers);
        //    }

        //    private static int[,] GridNumberGenerator()
        //    {
        //        int[,] gridNumbers = new int[3, 3];
        //        Random rng = new();
        //        for (int i = 0; i < gridNumbers.GetLength(0); i++)
        //        {
        //            for (int j = 0; j < gridNumbers.GetLength(1); j++)
        //            {
        //                gridNumbers[i, j] = rng.Next(0, 3);
        //                Console.Write(gridNumbers[i, j] + " ");
        //            }
        //            Console.WriteLine(" ");
        //        }

        //        return gridNumbers;

        //    }

        //    private static void GridResult(int[,] gridNumbers)
        //    {// matching vertical lines
        //        if ((gridNumbers[0, 0]) == (gridNumbers[0, 1]) && (gridNumbers[0, 1]) == (gridNumbers[0, 2]))
        //        {
        //            Console.WriteLine("Congrats You Win");
        //        }
        //        if ((gridNumbers[1, 0]) == (gridNumbers[1, 1]) && (gridNumbers[1, 1]) == (gridNumbers[1, 2]))
        //        {
        //            Console.WriteLine("Congrats You Win");
        //        }
        //        if ((gridNumbers[2, 0]) == (gridNumbers[2, 1]) && (gridNumbers[2, 1]) == (gridNumbers[2, 2]))
        //        {
        //            Console.WriteLine("Congrats You Win");
        //        }

        //        // matching vertical lines
        //        if ((gridNumbers[0, 0]) == (gridNumbers[1, 0]) && (gridNumbers[1, 0]) == (gridNumbers[2, 0]))
        //        {
        //            Console.WriteLine("congrats You Win");
        //        }
        //        if ((gridNumbers[0, 1]) == (gridNumbers[1, 1]) && (gridNumbers[1, 1]) == (gridNumbers[2, 1]))
        //        {
        //            Console.WriteLine("Congrats You Win");
        //        }
        //        if ((gridNumbers[0, 2]) == (gridNumbers[1, 2]) && (gridNumbers[1, 2]) == (gridNumbers[2, 2]))
        //        {
        //            Console.WriteLine("Congrats You Win");
        //        }
        //        // matching diagonal lines
        //        if ((gridNumbers[0, 0]) == (gridNumbers[1, 1]) && (gridNumbers[1, 1]) == (gridNumbers[2, 2]))
        //        {
        //            Console.WriteLine("Congrats You Win");
        //        }
        //        if ((gridNumbers[0, 2]) == (gridNumbers[1, 1]) && (gridNumbers[1, 1]) == (gridNumbers[2, 0]))
        //        {
        //            Console.WriteLine("Congrats You Win");
        //        }


        //    }

        //}

        //private static void GridChecker(int[,] grid)
        //{
        //    for (int i = 0; i < grid.GetLength(0); i++)
        //    {
        //        if (grid[i, 0] == grid[i, 1] && grid[i, 1] == grid[i, 2])  //horizontal lines

        //            if (grid[0, i] == grid[1, i] && grid[1, i] == grid[2, i]) //vertical lines


        //                if ((grid[0, 0]) == (grid[1, 1]) && (grid[1, 1]) == (grid[2, 2])) // diagonal lines

        //                    if ((grid[0, 2]) == (grid[1, 1]) && (grid[1, 1]) == (grid[2, 0])) ;// diagonal lines
        //    }
        //}

        //private static void GridDisplay()
        //{
        //    Console.WriteLine(" ");
        //}

        //static int[,] GridNumberGenerator()
        //{
        //    int[,] gridNumbers = new int[3, 3];
        //    Random rng = new();
        //    for (int i = 0; i < gridNumbers.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < gridNumbers.GetLength(1); j++)
        //        {
        //            gridNumbers[i, j] = rng.Next(0, 3);
        //            Console.Write(gridNumbers[i, j] + " ");
        //        }
        //        Console.WriteLine(" ");
        //    }

        //    return gridNumbers;

        //}
        ///// <summary>
        ///// Returns won cash value for a certain grid
        ///// </summary>
        ///// <param name="grid">the gird to check</param>
        ///// <returns>the won amount</returns>
        //static int CashWonWithGrid(int[,] grid)
        //{
        //    int cash = 0;

        //    for (int i = 0; i < grid.GetLength(0); i++)
        //    {
        //        if (grid[i, 0] == grid[i, 1] && grid[i, 1] == grid[i, 2])  //horizontal lines
        //        {
        //            cash += 2;
        //        }
        //        if (grid[0, i] == grid[1, i] && grid[1, i] == grid[2, i]) //vertical lines
        //        {
        //            cash += 2;
        //        }

        //    }

        //    if ((grid[0, 0]) == (grid[1, 1]) && (grid[1, 1]) == (grid[2, 2]))
        //    {
        //        cash += 5;
        //    }
        //    if ((grid[0, 2]) == (grid[1, 1]) && (grid[1, 1]) == (grid[2, 0]))
        //    {           
        //        cash += 5;
        //    }


        //    return cash;
        //}

        //static void GridResult(int[,] gridNumbers)
        //{    // matching vertical line.

        //    for (int i = 0; i < gridNumbers.GetLength(0); i++)
        //    {
        //        if (gridNumbers[i, 0] == gridNumbers[i, 1] && gridNumbers[i, 1] == gridNumbers[i, 2])
        //        {
        //            Console.WriteLine("you win");
        //        }
        //        if (gridNumbers[0, i] == gridNumbers[1, i] && gridNumbers[1, i] == gridNumbers[2, i])
        //        {
        //            Console.WriteLine("you win");
        //        }
        //    }

        //}



    }
}




















































































