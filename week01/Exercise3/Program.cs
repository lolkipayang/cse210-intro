using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number?");
        string magic = Console.ReadLine();
        Console.Write("What is your guess?");
        string guess = Console.ReadLine();
        int magicNum = int.Parse(magic);
        int guessNum = int.Parse(guess);
        
        if (guessNum > magicNum)
        {
            Console.WriteLine("Lower");
        }
        else if (guessNum == magicNum)
        {
            Console.WriteLine("You guessed it");
        }
        else
        {
            Console.WriteLine("Higher");
        }
    }
}
