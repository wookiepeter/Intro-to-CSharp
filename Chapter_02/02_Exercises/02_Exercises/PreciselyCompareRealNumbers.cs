using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Exercises
{
    class PreciselyCompareRealNumbers
    {
        static void Main(string[] args)
        {
            double firstRealNumber;
            double secondRealNumber;

            Console.WriteLine("Please enter the first real number: ");
            firstRealNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second real number: ");
            secondRealNumber = double.Parse(Console.ReadLine());

            if (firstRealNumber == secondRealNumber)
            {
                Console.WriteLine("Both numbers are the same");
            }
            else
            {
                if (firstRealNumber > secondRealNumber)
                {
                    Console.WriteLine("first number > second number");
                }
                else
                {
                    Console.WriteLine("first number < second number");
                }
            }
        }
    }
}
