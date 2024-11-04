using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 11);

        string found = "no";

        // Console.Write("Please enter a number: ");
        // string number = Console.ReadLine();
        // int magicNumber = int.Parse(number);

        Console.WriteLine($"The magic number is {randomNumber}");

        do{
            Console.Write("Please guess a number: ");
            string numberGuess = Console.ReadLine();
            int guess = int.Parse(numberGuess);

            if (guess > randomNumber)
            {
                Console.WriteLine("lower");
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it");
                found = "yes";
            }

        } while (found == "no");

    }
}