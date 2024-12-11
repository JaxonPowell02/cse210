using System;
using System.Collections.Generic;

// Main Program Class
public class Program
{
    public static void Main()
    {
        Menu menu = new Menu();
        FarmManager farmManager = new FarmManager();

        while (true)
        {
            int choice = menu.MainMenu();
            switch (choice)
            {
                case 1:
                    HandleAnimalMenu(menu, farmManager);
                    break;
                case 2:
                    HandleCropMenu(menu, farmManager);
                    break;
                case 3:
                    HandleMachineryMenu(menu, farmManager);
                    break;
                case 4:
                    HandleEmployeeMenu(menu, farmManager);
                    break;
                case 5:
                    Console.WriteLine("Exiting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void HandleAnimalMenu(Menu menu, FarmManager farmManager)
    {
        while (true)
        {
            int choice = menu.AnimalMenu();
            switch (choice)
            {
                case 1:
                    farmManager.AddAnimal();
                    break;
                case 2:
                    farmManager.DisplayAnimalHealthStatuses();
                    break;
                case 3:
                    farmManager.DisplayAllAnimals();
                    break;
                case 4:
                    farmManager.FeedAnimal();
                    break;
                case 5:
                    farmManager.RemoveAnimal();
                    break;
                case 6: // Feed all animals with the same ID
                    farmManager.FeedAnimal();
                    break;
                case 7:
                    Console.WriteLine("Returning to Main Menu...\n");
                    return;
                default:
                    Console.WriteLine("Invalid option in Animal Menu. Please try again.\n");
                    break;
            }
        }
    }

    private static void HandleCropMenu(Menu menu, FarmManager farmManager)
    {
        while (true)
        {
            int choice = menu.CropMenu();
            switch (choice)
            {
                case 1:
                    farmManager.AddCrop();
                    break;
                case 2:
                    farmManager.DisplayCropGrowthStatuses();
                    break;
                case 3:
                    farmManager.DisplayAllCrops();
                    break;
                case 4:
                    farmManager.RemoveCrop();
                    break;
                case 5:
                    Console.WriteLine("Returning to Main Menu...\n");
                    return;
                default:
                    Console.WriteLine("Invalid option in Crop Menu. Please try again.\n");
                    break;
            }
        }
    }

    private static void HandleMachineryMenu(Menu menu, FarmManager farmManager)
    {
        while (true)
        {
            int choice = menu.MachineryMenu();
            switch (choice)
            {
                case 1:
                    farmManager.AddMachinery();
                    break;
                case 2:
                    farmManager.DisplayMachineryStatuses();
                    break;
                case 3:
                    farmManager.DisplayAllMachinery();
                    break;
                case 4:
                    farmManager.RemoveMachinery();
                    break;
                case 5:
                    Console.WriteLine("Returning to Main Menu...\n");
                    return;
                default:
                    Console.WriteLine("Invalid option in Machinery Menu. Please try again.\n");
                    break;
            }
        }
    }

    private static void HandleEmployeeMenu(Menu menu, FarmManager farmManager)
    {
        while (true)
        {
            int choice = menu.EmployeeMenu();
            switch (choice)
            {
                case 1:
                    farmManager.AddEmployee();
                    break;
                case 2:
                    farmManager.DisplayEmployeeRoles();
                    break;
                case 3:
                    farmManager.DisplayAllEmployees();
                    break;
                case 4:
                    farmManager.RemoveEmployee();
                    break;
                case 5:
                    Console.WriteLine("Returning to Main Menu...\n");
                    return;
                default:
                    Console.WriteLine("Invalid option in Employee Menu. Please try again.\n");
                    break;
            }
        }
    }
}
