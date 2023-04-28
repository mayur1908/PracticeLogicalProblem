using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class LargestNumber
    {
        public static void FindLargestNumber()
        {
            Console.WriteLine("WellCome Find largest Number");
            Console.WriteLine("Enter num1 num2 num3");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int largestNum = num1;

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + "is grettest");
                }
                else
                {
                    Console.WriteLine(num3 + "is grettest");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2 + "is grettest");
                }
                else
                {
                    Console.WriteLine(num3 + "is grettest");
                }
            }
        }
    }
}
