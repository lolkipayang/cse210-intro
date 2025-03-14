using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();
        
    
        int num;
        do
        {
            Console.Write("Enter a number greater or less than zero, or zero to quit: ");
            
            string userInput = Console.ReadLine();
            num = int.Parse(userInput);
            
    
            if (num != 0)
            {
                numbers.Add(num);
            }
        }
        while (num != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
    }
}
