class Menu
{
    public int MainMenu()
    {
        while (true)
        {
        Console.WriteLine("1. Animal Menu: ");
        Console.WriteLine("2. Crop Menu: ");
        Console.WriteLine("3. Machinery Menu");
        Console.WriteLine("4. Employee Menu: ");
        Console.WriteLine("Enter your choice (1-4) ");

        string userInput = Console.ReadLine();
        int input = int.Parse(userInput);

        return input;
        }   
    }

    public int AnimalMenu()
    {
        Console.WriteLine("\nAnimal Menu:");
        Console.WriteLine("1. Add Animal");
        Console.WriteLine("2. Display Animal Health Statuses");
        Console.WriteLine("3. Display All Animals");
        Console.WriteLine("4. Feed Animal");
        Console.WriteLine("5. Remove Animal");
        Console.WriteLine("6. Feed All Animals with Same ID"); // New option
        Console.WriteLine("7. Back to Main Menu");
        return int.Parse(Console.ReadLine());
    }

    public int CropMenu()
    {
        Console.WriteLine("\nCrop Menu:");
        Console.WriteLine("1. Add Crop");
        Console.WriteLine("2. Display Crop Growth Statuses");
        Console.WriteLine("3. Display All Crops");
        Console.WriteLine("4. Remove Crop");
        Console.WriteLine("5. Back to Main Menu");
        return int.Parse(Console.ReadLine());
    }


    public int MachineryMenu()
    {
        Console.WriteLine("1. Add New Machinery");
        Console.WriteLine("2. Machinery Status");
        Console.WriteLine("3. Display Machinery Details");
        Console.WriteLine("4. Remove Machinery"); 
        Console.WriteLine("5. Return to Main Menu");
        Console.WriteLine("Enter your choice (1-4):");

        return int.Parse(Console.ReadLine());
    }

    public int EmployeeMenu()
    {
        Console.WriteLine("1. Add New Employee");
        Console.WriteLine("2. Employee Status");
        Console.WriteLine("3. Display Employee Details");
        Console.WriteLine("4. Remove Employee"); 
        Console.WriteLine("5. Return to Main Menu");
        Console.WriteLine("Enter your choice (1-4):");

        return int.Parse(Console.ReadLine());
    }

}