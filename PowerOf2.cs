using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class PowerOf2
    {
        public static void FindPowerOf2()
        {
            Console.WriteLine("Enter number Between 0 and 31: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0 && n < 31)
            {
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }

    }
}
