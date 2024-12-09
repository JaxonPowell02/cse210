class Menu
{
    public int MainMenu()
    {
        int value = 0;
        Console.WriteLine("1. Animal Menu: ");
        Console.WriteLine("2. Crop Menu: ");
        Console.WriteLine("3. Machinery Menu");
        Console.WriteLine("4. Employee Menu: ");
        Console.WriteLine("Enter your choice (1-4) ");

        string userInput = Console.ReadLine();
        int input = int.Parse(userInput);

        switch (input)
        {
            case 1:
                value = AnimalMenu();
                break;
            case 2: 
                value = CropMenu();
                break;
            case 3:
                value = MachineryMenu();
                break;
            case 4:
                value = EmployeeMenu();
                break;
            
        }
        return value;
    } 

    public int AnimalMenu()
    {
        Console.WriteLine("1. Add New Animal: ");
        Console.WriteLine("2. Health Status: "); // This will display just the name and the health 
        Console.WriteLine("3. Display Animal Details: ");
        Console.WriteLine("Enter your choice (1-3) ");

        string userInput = Console.ReadLine();
        int input = int.Parse(userInput);
        return input;
    }

    public int CropMenu()
    {
        Console.WriteLine("1. Add New Crop: ");
        Console.WriteLine("2. Crop Status: "); // This will display just the name and the growth status 
        Console.WriteLine("3. Display Crop Details: ");
        Console.WriteLine("Enter your choice (1-3) ");

        string userInput = Console.ReadLine();
        int input = int.Parse(userInput);
        input = input + 10;
        return input;
    }

    public int MachineryMenu()
    {
        Console.WriteLine("1. Add New Machinery: ");
        Console.WriteLine("2. Machinery Status: "); // This will display just the name and the useage staus
        Console.WriteLine("3. Display Machinery Details: ");
        Console.WriteLine("Enter your choice (1-3) ");

        string userInput = Console.ReadLine();
        int input = int.Parse(userInput);
        input = input +20;
        return input;
    }

    public int EmployeeMenu()
    {
        Console.WriteLine("1. Add New Employee: ");
        Console.WriteLine("2. Employee Status: ");
        Console.WriteLine("3. Display Employee Details: ");
        Console.WriteLine("Enter your choice (1-3) ");

        string userInput = Console.ReadLine();
        int input = int.Parse(userInput);
        input = input + 30;
        return input;
    }
}