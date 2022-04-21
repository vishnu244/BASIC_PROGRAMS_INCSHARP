using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs_in_csharp
{
    public class Leapyear
    {
        public void LeapYear()
        {
            Console.WriteLine("Welcome to Leap Year Computation!");

            Console.WriteLine("Enter the Year : x");
            var x = Convert.ToDouble(Console.ReadLine());

            if (((x % 4 == 0) && (x % 100 != 0)) || (x % 400 == 0))
                Console.WriteLine("{0} is a Leap Year ", x);
            else
                Console.WriteLine("{0} is not a Leap Year ", x);
        }
    }
}
