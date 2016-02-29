using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class readAgeFromConsole
    {
        static void Main()
        {
            string Input = "";
            string[] splittedString;
            DateTime BirthDate;
            TimeSpan currentAge, newAge;
            int ageInYears = 0;

            Console.WriteLine("Enter your Date of Birth(DD.MM.YYYY)");
            Input = Console.ReadLine();

            splittedString = Input.Split('.');
            int day = int.Parse(splittedString[0]);
            int month = int.Parse(splittedString[1]);
            int year = int.Parse(splittedString[2]);

            BirthDate = new DateTime(year, month, day);
            currentAge = DateTime.Today.Subtract(BirthDate);
            newAge = DateTime.Today - BirthDate;

            Console.WriteLine(DateTime.Today.ToString());
            Console.WriteLine(BirthDate.ToString());

            ageInYears = DateTime.Today.AddYears(10).Year - BirthDate.Year;

            if (DateTime.Today.DayOfYear.CompareTo(BirthDate.DayOfYear) < 0)
            {
                ageInYears--;  
            }
           
            Console.WriteLine(ageInYears);
        }
    }
}
