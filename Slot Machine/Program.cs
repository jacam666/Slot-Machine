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


            int[,] number = new int[,]
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 },
            };

                 Random num = new();
            for (int i = 0; i < 3; i++)
            {
                int value = num.Next(0, number.Length);
                Console.WriteLine("{0} {0} {0}", value);
            }




            //
            //int value = number.Next(0, int.getUpperBound);
            //Console.Write(array[value]);
        }
        
    }



}
    //Console.WriteLine(number[0, 2]);

















    

