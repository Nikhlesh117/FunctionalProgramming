using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    public class LargestNumber
    {
        public static void FindTheLargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the Largest of three Number");
            Console.WriteLine("Input the 1st number");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2nd number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3rd number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if(num1 > num3) 
                {
                    Console.WriteLine("The 1st number is greatest among three ");
                }
                else
                {
                    Console.WriteLine("the 3rd number is greatest among three ");
                }
            }
            else if(num2> num3)
            {
                Console.WriteLine("the 2nd number is greatest among three ");
            }
            else
            {
                Console.WriteLine("the 3rd number is greatest among three ");
            }
        }
    }
}
