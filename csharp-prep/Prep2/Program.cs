using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";

        if (percent >= 97)
        {
            letter = "A";
        }
        else if (percent < 93 && percent >= 90)
        {
            letter = "A-";
        }
        else if (percent >= 83 && percent < 87)
        {
            letter = "B";
        }
        else if (percent >= 87 && percent < 90)
        {
            letter = "B+";
        }
        else if (percent < 83 && percent >= 80)
        {
            letter = "B-";
        }
        else if (percent >= 73 && percent< 77)
        {
            letter = "C";
        }
        else if (percent >= 77 && percent < 80)
        {
            letter = "C+";
        }
        else if (percent < 73 && percent >=70)
        {
            letter = "C-";
        }
        else if (percent >= 63 && percent < 67)
        {
            letter = "D";
        }
                else if (percent >= 67 && percent < 70)
        {
            letter = "D+";
        }
        else if (percent < 63 && percent >= 60)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    } 
}
