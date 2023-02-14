using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class Factor
    {
        public static void FindFactor()
        {
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n = n / i;
                }
            }
            if (n > 1)
            {
                Console.Write(n);
            }
        }

    }
}
