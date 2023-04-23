using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int usernumber = -1;

        while (usernumber != 0)
        {
            Console.Write("Enter number: ");

            string userinput = Console.ReadLine();
            usernumber = int.Parse(userinput);

            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }
        }
        
        int sum = 0;
        
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        float count = (numbers.Count);
        float average = (sum / count);

        int maxNumber = 0;
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }

        }

        int minPositive = 1000;
        foreach (int number in numbers)
        {
            if (number > 0 && number < minPositive)
            {
                minPositive = number;
            }

        }

        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine($"The lowest positive number is: {minPositive}");

    }
}