using System;
/*I am adding something to see where it goes*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("Please enter your name");

        String name;

        name = Console.ReadLine();

        Console.WriteLine($"Your name is: {name}");
        Console.Write("Input your age: ");
        string userInput = Console.ReadLine();
        int age = int.Parse(userInput);

        Console.WriteLine($"Your age is {age}");

        int x = 10;

        if (x > 15){
            Console.WriteLine("Hey Bob");
        }
    }
}