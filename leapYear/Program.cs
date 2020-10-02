using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int leap;
            Console.WriteLine("Enter the year");
            leap = Convert.ToInt32(Console.ReadLine());
            if((leap%400)==0)
            {
                Console.WriteLine("The year is leap year");
            }
            else if ((leap % 100) == 0)
            {
                Console.WriteLine("The year is not leap year");
            }
            else if ((leap % 4) == 0)
            {
                Console.WriteLine("The year is leap year");
            }
            else
            {
                Console.WriteLine("The year is not leap year");
            }
            Console.ReadKey();
        }
    }
}
