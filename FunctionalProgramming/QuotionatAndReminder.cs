using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class QuotionatAndReminder
    {
        public static void QuotionatReminder()
        {
            Console.WriteLine("WelllCome To QuotionatAndReminder");
            Console.WriteLine("Enter the Dividend");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor");
            int divisor= Convert.ToInt32(Console.ReadLine());
            int quo = divident / divisor;
            int rem = divident % divisor;
            Console.WriteLine("the quotiont is  " + quo);
            Console.WriteLine("the remider is  "+ rem);
        }
        
    }
}
