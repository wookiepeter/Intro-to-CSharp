using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class printSequenceToConsole
    {
        static void Main()
        {
            int number = -1;

            for(int i = 0; i <= 100; i++)
            {
                number = (number * -1);

                if(number > 0)
                {
                    number++;
                }
                else
                {
                    number--;
                }

                Console.WriteLine(number);
            }
        }
    }
}
