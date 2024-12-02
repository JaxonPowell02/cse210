using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            int choice = GetUserChoice();

            switch (choice)
            {
                case 1:
                    RunBreathingActivity();
                    break;
                case 2:
                    RunReflectionActivity();
                    break;
                case 3:
                    RunListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("\n--- Mindfulness Program ---");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
    }

    private static int GetUserChoice()
    {
        Console.Write("Enter your choice (1-4): ");
        return int.Parse(Console.ReadLine());
    }

    private static void RunBreathingActivity()
    {
        Breathing activity = new Breathing(" ", 0);
        activity.Duration = activity.GetDuration();
        activity.Run(activity.Duration);
    }

    private static void RunReflectionActivity()
    {
        Reflection activity = new Reflection(" ", 0);
        activity.Duration = activity.GetDuration();
        activity.Run();
    }

    private static void RunListingActivity()
    {
        Listing activity = new Listing(" ", 0);
        activity.Duration = activity.GetDuration();
        activity.Run();
    }
}