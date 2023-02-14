using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class EvenOrOdd
    {
        public static void FindEvenOrOdd()
        {
            int num;

            Console.WriteLine("Find the Number is Even or Odd");
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            if(num%2 == 0)
            {
                Console.WriteLine("Number is Even : " + num);
            }
            else
            {
                Console.WriteLine("Number is odd : " + num);
            }
        }
    }
}
