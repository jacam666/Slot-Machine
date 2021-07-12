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

            string playerName;
            Console.Write("Please Enter Player's Name: ");
            playerName = Console.ReadLine();
            Console.WriteLine($"Welcome to my slot game " + playerName);
            Console.Write("Amount of Cash you would like to use in the slots: £");
            double cash = Convert.ToDouble(Console.ReadLine());
            string response;
            //int[,] gridNumbers = GridNumberGenerator();
            //GridResult(gridNumbers);
            for (; ; ) // Loop forever
            {
                if (cash <= 0)
                {
                    Console.WriteLine("You are out of cash. Game over.");
                    Console.Read();
                    break;
                }
                Console.WriteLine("Cash = {0}", cash);
                Console.WriteLine("Play Slots? y/n");
                response = Console.ReadLine();
                if (response == "n")
                {
                    break;
                }
                else
                {
                    cash -= 1;

                    int[,] gridNumbers = new int[3, 3];
                    Random rng = new();
                    for (int i = 0; i < gridNumbers.GetLength(0); i++)
                    {
                        for (int j = 0; j < gridNumbers.GetLength(1); j++)
                        {
                            gridNumbers[i, j] = rng.Next(0, 6);
                            Console.Write(gridNumbers[i, j] + " ");
                        }
                        Console.WriteLine(" ");
                    }

                    for (int i = 0; i < gridNumbers.GetLength(0); i++)
                    {
                        if (gridNumbers[i, 0] == gridNumbers[i, 1] && gridNumbers[i, 1] == gridNumbers[i, 2])
                        {
                            Console.WriteLine("you win");
                            cash += 2;
                        }
                        if (gridNumbers[0, i] == gridNumbers[1, i] && gridNumbers[1, i] == gridNumbers[2, i])
                        {
                            Console.WriteLine("you win");
                            cash += 2;
                        }
                       
                    }// adding diagonal winning lines.
                    if ((gridNumbers[0, 0]) == (gridNumbers[1, 1]) && (gridNumbers[1, 1]) == (gridNumbers[2, 2]))
                    {
                        Console.WriteLine("Congrats You Win");
                        cash += 5;
                    }
                    if ((gridNumbers[0, 2]) == (gridNumbers[1, 1]) && (gridNumbers[1, 1]) == (gridNumbers[2, 0]))
                    {
                        Console.WriteLine("Congrats You Win");
                        cash += 5;
                    }

                }
            }

            //static int[,] GridNumberGenerator()

            //{
            //int[,] gridNumbers = new int[3, 3];
            //Random rng = new();
            //for (int i = 0; i < gridNumbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < gridNumbers.GetLength(1); j++)
            //    {
            //        gridNumbers[i, j] = rng.Next(0, 3);
            //        Console.Write(gridNumbers[i, j] + " ");
            //    }
            //    Console.WriteLine(" ");
            //}

            //return gridNumbers;

            //}

            //static void GridResult(int[,] gridNumbers)
            //{    // matching vertical line.

            //for (int i = 0; i < gridNumbers.GetLength(0); i++)
            //{
            //    if (gridNumbers[i, 0] == gridNumbers[i, 1] && gridNumbers[i, 1] == gridNumbers[i,2])
            //    {
            //        Console.WriteLine("you win");
            //    }
            //    if (gridNumbers[0, i] == gridNumbers[1, i] && gridNumbers[1, i] == gridNumbers[2, i])
            //    {
            //        Console.WriteLine("you win");
            //    }
            //}





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

        }
    }
}
















































































