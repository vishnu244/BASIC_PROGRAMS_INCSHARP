﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs_in_csharp
{
    public class quotientremainder
    {
        public void QuotientRemainder()
        {
            Console.WriteLine("Enter the Values of Divisor : ");
            var Divisor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Values of Dividend : ");
            var Dividend = Convert.ToDouble(Console.ReadLine());

            double quotient = Dividend / Divisor;
            double remainder = Dividend % Divisor;

            Console.WriteLine("Value of Quotient : {0}", quotient);
            Console.WriteLine("Value of Remainder : {0}", remainder);

        }
    }
}
