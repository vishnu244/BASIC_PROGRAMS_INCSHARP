using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs_in_csharp
{
    public class evenodd
    {
        public void EvenOdd()
        {
            Console.WriteLine("Checking whether a number is Even or Odd!");

            Console.WriteLine("Enter a Value x");
            var x = Convert.ToDouble(Console.ReadLine());

            if (x % 2 == 0)
                Console.WriteLine("{0} is an Even Number", x);
            else
                Console.WriteLine("{0} is an Odd Number ", x);
        }
    }
}
