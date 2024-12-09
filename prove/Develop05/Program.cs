using System;

class Program
{
   static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. Record an Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                case "2":
                    RecordEvent(manager);
                    manager.DisplayTotalScore();
                    break;
                case "3":
                    manager.DisplayGoals();
                    break;
                case "4":
                    manager.SaveGoals("goals.txt");
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case "5":
                    manager.LoadGoals("goals.txt");
                    Console.WriteLine("Goals loaded successfully.");
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
        }
    }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("\nCreate a Goal");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select goal type: ");

        string goalType = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, description, points));
                Console.WriteLine("Simple Goal created successfully.");
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, description, points));
                Console.WriteLine("Eternal Goal created successfully.");
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                Console.WriteLine("Checklist Goal created successfully.");
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordEvent(GoalManager manager)
    {
        Console.WriteLine("\nRecord an Event");
        Console.Write("Enter the name of the goal to record: ");
        string goalName = Console.ReadLine();
        manager.RecordEvent(goalName);
        Console.WriteLine("Event recorded.");
    }

    
}