using System;

class Program
{
    static void Main(string[] args)
    {
         if (number >= 90)
        {
            Console.Write("Your grade is A");
            string letter = Console.ReadLine();
        }
        else if (number >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if (number >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if (number >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }
        if (number >= 70)
        {
            Console.WriteLine("Congratulation you have passed the course");
        }
        else
        {
            Console.WriteLine("Work hard next time and you will pass the course");
        }
        
    }
}
