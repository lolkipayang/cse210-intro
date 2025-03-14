using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score? ");
        string score = Console.ReadLine();
        int number = int.Parse(score);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");
        
        if (number >= 70)
        {
            Console.WriteLine("Congratulation you have passed the course");
        }
        else
        {
            Console.WriteLine("Work hard next time and you will pass the course!");
        }
        
            
        
    }
}
