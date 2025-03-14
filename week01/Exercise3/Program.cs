using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is the magic number? ");
        string magic = Console.ReadLine();
        int magicNum = int.Parse(magic);
        int guessNum = 0;
        do 
        {

            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNum = int.Parse(guess);

            if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        while (guessNum != magicNum);
    }
}
