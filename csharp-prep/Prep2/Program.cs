using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percenage: ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);
        string letter;

        if (grade >= 90)
        {
            letter = "A";
            Console.WriteLine($"Your grade is a {letter}");
        }
        else if (grade >= 80)
        {
            letter = "B";
            Console.WriteLine($"Your grade is a {letter}");
        }
        else if (grade >= 70)
        {
            letter = "C";
            Console.WriteLine($"Your grade is a {letter}");
        }
        else if (grade >= 60)
        {
            letter = "D";
            Console.WriteLine($"Your grade is a {letter}");
        }
        else
        {
            letter = "F";
            Console.WriteLine($"Your grade is a {letter}");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Your grade is above 70% you passed the class!");
            Console.WriteLine("Congradulation");
        }
        else
        {
            Console.WriteLine("You didn't pass the class");
        }

    }
}