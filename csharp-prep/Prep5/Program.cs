using System;
using System.ComponentModel;
using System.Globalization;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string askForUserName()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter a number: ");
        string usernumber = Console.ReadLine();
        int number = int.Parse(usernumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = askForUserName();
        int number = PromptUserNumber();
        int SquaredNumber = SquareNumber(number);
        Console.WriteLine($"{name}, your number is {number}, and squard is {SquaredNumber}");
    }
}