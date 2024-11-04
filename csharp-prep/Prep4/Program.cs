using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();
        string exit = "false";
        int total;
        int start = 0;
        do 
        {
            Console.Write("Enter a number: ");
            string userinput = Console.ReadLine();
            int input = int.Parse(userinput);
            numbers.Add(input);

            if (input == 0)
            {
                exit = "true";
            }


        } while (exit == "false");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);

        }

        foreach (int number in numbers)
        {
            if (number > start)
            {
                start = number;
            }
        }
        int listLength = numbers.Count;
        Console.WriteLine($"list length: {listLength}");
        total = numbers.Sum();
        int average = total / listLength;

        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest number: {start}");
    }
}