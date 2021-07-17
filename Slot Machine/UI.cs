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
            Console.WriteLine("Welcome to my slot game ");
        }

        public static void DisplayCurrentSlotGrid(int[,] grid)
        {
        
        }
        public static void DisplayWinInfo(int amount )
        {
            if (amount > 0)
                //cash = cash + amount;
                Console.WriteLine($"You win!! £{amount}");
                
        }
        public static void GridDisplay()
        {

            Console.WriteLine(" ");
        }


    }
}
