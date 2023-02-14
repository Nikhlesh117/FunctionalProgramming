using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class HarmonicNumber
    {
        public static void FindHarmonicNumber()
        {
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            float Harmonic = 1;
            if (n != 0)
            {
                for (int i = 2; i <= n; i++)
                {
                    Harmonic += 1 / (float)i;
                }
                Console.WriteLine("\nSum of Series upto {0} terms : {1} \n", n, Harmonic);
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }

    }
}
