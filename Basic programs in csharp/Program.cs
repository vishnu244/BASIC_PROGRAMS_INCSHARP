// See https://aka.ms/new-console-template for more information
using Basic_programs_in_csharp;

Console.WriteLine("Basic programming");


while (true)
{

    Console.WriteLine("Choose the Program to be executed :\n1)flipcoinsimulator\n2)leapyear\n3)evenodd\n4)vowelcoonsonent\n5)Maxofthree\n6)swapnumbers\n7)quotientandremainder\n8)powerof2\n9)HarmonicSeries");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Flipcoin flipCoin = new();
            flipCoin.FlipCoin();
            break;
        case 2:
            Leapyear leapyear = new();
            leapyear.LeapYear();
            break;
        case 3:
            evenodd Evenodd = new();
            Evenodd.EvenOdd();
            break;
        case 4:
            vowelconsonent VowelConsonent = new();
            VowelConsonent.VowelConsosnent();
            break;
        case 5:
            Maximumofthreenumbers MaxOfThree = new();
            MaxOfThree.MaxOfThree();
            break;
        case 6:
            swapnumbers SwapNumbers = new();
            SwapNumbers.SwapNumbers();
            break;
        case 7:
            quotientremainder QuotientRemainder = new();
            QuotientRemainder.QuotientRemainder();
            break;
        case 8:
            Powerof2 PowerOf2 = new();
            PowerOf2.PowerOf2();
            break;
        case 9:
            harmonicseries harmonic = new();
            harmonic.HarmonicSeries();
            break;
        default: 
            break;

    }


}