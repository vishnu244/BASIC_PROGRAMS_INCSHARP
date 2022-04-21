using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs_in_csharp
{
    public class swapnumbers
    {
        public void SwapNumbers()
        {

            Console.WriteLine("Enter the values of a and b");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Before Swap value of a = " + a + " value of b = " + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Before Swap value of a = " + a + " value of b = " + b);
        }
    }
}
