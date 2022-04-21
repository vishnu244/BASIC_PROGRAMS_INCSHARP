using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs_in_csharp
{
    public class Flipcoin
    {
        public void FlipCoin()
        {
            Console.WriteLine("Let's Flip a Coin For N Times");
            var N = Convert.ToDouble(Console.ReadLine());
            {


                Random rand = new Random();
                int heads = 0;
                int tails = 0;


                for (int i = 0; i < N; i++)
                {

                    int Rolldie = rand.Next(0, 2);
                    Console.WriteLine(Rolldie);

                    if (Rolldie == 1)
                    {
                        Console.WriteLine("HEADS");
                        heads++;
                    }
                    else
                    {
                        Console.WriteLine("TAILS");
                        tails++;
                    }
                }
                Console.WriteLine("Heads Flipped for {0} times", heads);
                Console.WriteLine("Tails Flipped for {0} times", tails);


            }
        }

    }
}
