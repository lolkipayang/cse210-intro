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
    }
}
