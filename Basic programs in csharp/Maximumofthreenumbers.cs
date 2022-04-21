using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs_in_csharp
{
    public class Maximumofthreenumbers
    {
        public void MaxOfThree()
        {
            Console.WriteLine("Enter the values of a ,b and c");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.Write("{0} is the largest value ", a);
                }
                else
                {
                    Console.Write("{0} is the largest value ", c);
                }
            }
            else if (b > c)
                Console.Write("{0} is the largest value ", b);
            else
                Console.Write("{0} is the largest value ", c);
        }
    }
}
