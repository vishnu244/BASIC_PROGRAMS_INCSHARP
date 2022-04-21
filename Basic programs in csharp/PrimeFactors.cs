using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs_in_csharp
{
    public class PrimeFactors
    {
        public void Primefactors()
        {
            Console.WriteLine("Prime factors of given number");
            Console.WriteLine("Enter the value : ");
            int P = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Prime factors of {0} are : ", P);
            for (int i = 2; P > 1; i++)
            {
                while (P % i == 0)
                {
                    P /= i;
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
