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
            //string[,] name = new string[,]
            //{
            //        {"corben", "cameron" },
            //        {"caidee", "cameron" },
            //        {"cole", "cameron" },
            //        {"claire", "cameron"},
            //};
            //for (int i = 0; i <= name.GetUpperBound(0); i ++)
            //{
            //    string firstName = name[i, 0];
            //    string lastName = name[i, 1];
            //    Console.WriteLine("{0} {1}",firstName, lastName);
            //}

            //selecting a position in the array

            // string[,] name = new string[,]
            //{
            //         {"corben", "cameron" },
            //         {"caidee", "cameron" },
            //         {"cole", "cameron" },
            //         {"claire", "cameron"},
            //};
            // Console.WriteLine(name[3, 0]);

            //   string[,] name = new string[,]
            //{
            //           {"corben", "cameron:", "Vandyke" },
            //           {"caidee", "cameron:", "Broklands" },
            //           {"cole", "cameron:", "UCL" },
            //           {"claire", "cameron:", "Leedon"},
            //};
            //   for(int i = 0; i <= name.GetUpperBound(0); i ++)
            //   {
            //       string firstName = name[i, 0];
            //       string lastName = name[i, 1];
            //       string school = name[i, 2];
            //       Console.WriteLine("{0} {1} {2}", firstName, lastName, school);
            //   }


            //   string[,] name = new string[,]
            //{
            //           {"corben", "cameron:", "Vandyke" },
            //           {"caidee", "cameron:", "Broklands" },
            //           {"cole", "cameron:", "UCL" },
            //           {"claire", "cameron:", "Leedon"},
            //};
            //   Console.WriteLine(name[0, 2]);

            //int[] oneDim = new int[50];
            //initializes an 2 dimensinal array with the size 3 by 3

            //UI.DisplayWelcomeScreen();



            //for (int i = 0; i < oneDim.Length; i++)
            //{
            //    oneDim[i] = rng.Next(2);
            //}


            //fill 2d array with random numbers

            //int[,] number = new int[3, 3];
            // Random rng = new();

            //for (int i = 0; i < number.GetLength(0); i++)
            //{
            //    for (int j = 0; j < number.GetLength(1); j++)
            //    {
            //        number[i, j] = rng.Next();
            //        Console.WriteLine("{0}", i);
            //    }
            //    //Console.WriteLine($"{number} {number} {number}", i );

            //}



            //int value = rng.Next(0, number.Length);
            ////    Console.WriteLine("{0} {0} {0}", value);

            //Console.WriteLine($"{value} {value} {value}");
            //int[,] number = new int[,];
            //int[] gridNumbers = new int[9];
            //gridNumbers[0] = 1;
            //gridNumbers[1] = 2;
            //gridNumbers[2] = 3;
            //gridNumbers[3] = 4;
            //gridNumbers[4] = 5;
            //gridNumbers[5] = 6;
            //gridNumbers[6] = 7;
            //gridNumbers[7] = 8;
            //gridNumbers[8] = 9;
            //Random num = new();
            //for (int i = 0; i < 3; i++)
            //{
            //    int value = num.Next(0, gridNumbers.Length);
            //    Console.WriteLine("{0} {0} {0}",value);
            //Console.WriteLine("{0} {0} (0}",value);



            //var number = new[,]
            //{
            //    {0.1, 0.2, 0.3,},
            //    {1.1, 1.2, 1.3,},
            //    {2.1, 2.2, 2.3,},
            //    {3.1, 3.2, 3.3,},
            //};
            //for (int i = 0; i < 3; i++)
            //{
            //    int value = number.Next(0, number.Length);
            //    Console.WriteLine("{0}", value);
            //}

            //int[,] gridNumbers = new int [3, 3];

            //Random num = new();

            //for (int i = 0; i < gridNumbers.GetLength(0); i++)
            //{

            //    for (int j = 0; j < gridNumbers.GetLength(1); j++) 
            //    {

            //        int gridNumber = num.Next(0, gridNumbers.Length);
            //        Console.WriteLine($"{0}" + "{0}" + "{0}", gridNumber);
            //    }
            //}



            //int[,] number = new int[3, 3];
            //Random rng = new();

            //for (int i = 0; i < number.GetLength(0); i++)
            //{
            //    for (int j = 0; j < number.GetLength(1); j++)
            //    {
            //        number[i, j] = rng.Next();
            //        Console.Write(number[i, j] + " ");
            //    }
            //    Console.WriteLine(" ");

            //}


            int[,] gridNumbers = new int[3, 3];
            Random rng = new();
            for (int i = 0; i < gridNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < gridNumbers.GetLength(1); j++)
                {
                    gridNumbers[i, j] = rng.Next(0,9);
                    Console.Write(gridNumbers[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            if ((gridNumbers[0,0]) == (gridNumbers[0,1]) && (gridNumbers[0,1]) == (gridNumbers[0,2]))
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










            //int gridPosition1 = [0, 2];
            //int gridPosition2 = [0, 2];
            //int gridPosition3 = [0, 2];

            //if ((gridPosition1 == gridPosition2) && (gridPosition2 == gridPosition3))
            //{
            //    Console.WriteLine("You win!!!");
            //}


            //int gridPosition1 = ([0, 0],[0, 1],[0, 2]);
            //int gridPosition2 = ([1, 0],[1, 1],[1, 2]);
            //int gridPosition3 = ([2, 0],[2, 1],[2, 2]);

            //if ((gridPosition1 == gridPosition2) && (gridPosition2 == gridPosition3))
            //{
            //    Console.WriteLine("You win!!!");
            //}

            //int reelspin1 = rng.Next(0, 9);
            //int reelspin2 = rng.Next(0, 9);
            //int reelspin3 = rng.Next(0, 9);
            //if ((reelspin1 == reelspin2) && (reelspin2 == reelspin3))
            //{
            //    Console.WriteLine("You win!!!");
            //}

            //bool spin = (0, 0 == 0, 1) && (0, 1 == 0, 2);



















        }



        //int[,] GenerateRandom2Darray()
        //{

        //}

    }
}

















































































