using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class LeapYear
    {
        public static void Year()
        {
            Console.WriteLine("Enter the year");
            int Year = Convert.ToInt32(Console.ReadLine());

            if (Year>999)
            {
                if (Year % 400 == 0)
                {
                    Console.WriteLine("This is leap year : " + Year);
                }
                else if (Year % 100 == 0)
                {
                    Console.WriteLine("This is not leap year : " + Year);
                }
                else if (Year % 4 == 0)
                {
                    Console.WriteLine("This is leap year : " + Year);
                }
                else
                {
                    Console.WriteLine("This is not leap year : " + Year);
                }
            }
            else
            {
                Console.WriteLine("enter 4 digit number");
            }

        }
    }
}
