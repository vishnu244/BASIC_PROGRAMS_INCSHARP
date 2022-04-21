using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs_in_csharp
{
    public class vowelconsonent
    {
        public void VowelConsosnent()
        {
            Console.WriteLine("Vowel or Consonent!");

            Console.WriteLine("Please Enter an Alphabet (A-Z or a-z) x : ");
            char x = Convert.ToChar(Console.ReadLine());



            if (x == 'A' || x == 'a')
                Console.WriteLine("Entered Alphabet is Vowel");
            else if (x == 'E' || x == 'e')
                Console.WriteLine("Entered Alphabet is Vowel");
            else if (x == 'I' || x == 'i')
                Console.WriteLine("Entered Alphabet is Vowel");
            else if (x == 'I' || x == 'i')
                Console.WriteLine("Entered Alphabet is Vowel");
            else if (x == 'U' || x == 'u')
                Console.WriteLine("Entered Alphabet is Vowel");
            else
                Console.WriteLine("Entered Alphabet is a Consonent");

            /*
            switch (x)
            {
                case 'a':
                    Console.WriteLine("Entered Alphabet is Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Entered Alphabet is Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Entered Alphabet is Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Entered Alphabet is Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Entered Alphabet is Vowel");
                    break;
                case 'A':
                    Console.WriteLine("Entered Alphabet is Vowel");
                    break;
                case 'E':
                    Console.WriteLine("Entered Alphabet is Vowel");
                    break;
                case 'I':
                    Console.WriteLine("Entered Alphabet is Vowel");
                    break;
                case 'O':
                    Console.WriteLine("Entered Alphabet is Vowel");
                    break;
                case 'U':
                    Console.WriteLine("Entered Alphabet is Vowel");
                    break;
                default:
                    Console.WriteLine("Entered Alphabet is a Consonent");
                    break;
            }
            */
        }


    }
}
