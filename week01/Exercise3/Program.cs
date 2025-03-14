using System;

class Program
{
    static void Main(string[] args)
    {
       Random random = new Random();
        int magicNum = random.Next(1, 101); // Generates a number between 1 and 100
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
