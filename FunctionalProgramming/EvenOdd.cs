using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class EvenOdd
    {
        public static void EvenAndOdd()
        {
            Console.WriteLine("Enter a number:");
            Random rnd = new Random();
            int num = rnd.Next(35);
            Console.WriteLine("thw num is " + num);


            if (num % 2 == 0)
            {
                Console.WriteLine(num + " The number is even.");
            }
            else
            {
                Console.WriteLine(num + " The number is odd.");
            }
        }
    }
}
