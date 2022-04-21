// See https://aka.ms/new-console-template for more information
using Basic_programs_in_csharp;

Console.WriteLine("Basic programming");


while (true)
{

    Console.WriteLine("Choose the Program to be executed :\n1)flipcoinsimulator\n2)leapyear");
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
        default: 
            break;

    }


}