using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("Please enter your name");

        String name;

        name = Console.ReadLine();

        Console.WriteLine($"Your name is: {name}");
    }
}