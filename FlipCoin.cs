using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class FlipCoin
    {
        public static void PercentCoin()
        {

            Console.WriteLine("Please enter the value for number of coin files");

            int head=0; 
            int tail=0;
            int headcount = 0;
            int tailcount = 0;

            double HeadPercentage;
            double tailPercentage;

            int flipCoin = Convert.ToInt32(Console.ReadLine());
            if (flipCoin > 0)
            {
                for (int i = 0; i < flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine("The Random number generated is {0}", number);
                    if(number == 0)
                    {
                        Console.WriteLine("Head");
                        headcount++;
                    }
                    else
                    {
                        Console.WriteLine("Tail");
                        tailcount++;
                    }
                    
                }
                Console.WriteLine("The Head count is " + headcount);
                Console.WriteLine("The Head count is " + tailcount);

                HeadPercentage = headcount * 100 / flipCoin;
                tailPercentage = tailcount * 100 / flipCoin;

                Console.WriteLine("The Head Percentage is " + HeadPercentage);
                Console.WriteLine("The Head Percentage is " + tailPercentage);
            }

            else
            {
                Console.WriteLine("enter valid number");
            }
        }
    }
}