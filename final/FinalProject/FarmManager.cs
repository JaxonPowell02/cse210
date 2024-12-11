public class FarmManager
{
    private List<FarmEntity> entities = new List<FarmEntity>();

    // Add a generic entity to the farm
    public void AddEntity(FarmEntity entity)
    {
        entities.Add(entity);
        Console.WriteLine($"{entity.Name} added to the farm.\n");
    }

    // Remove an entity from the farm by ID
    public void RemoveEntity(int id)
    {
        var entity = entities.Find(e => e.ID == id);
        if (entity != null)
        {
            entities.Remove(entity);
            Console.WriteLine($"{entity.Name} removed from the farm.\n");
        }
        else
        {
            Console.WriteLine($"Entity with ID {id} not found.\n");
        }
    }

    // View details of all entities on the farm
    public void ViewAllEntities()
    {
        Console.WriteLine("Farm Entities:");
        foreach (var entity in entities)
        {
            entity.DisplayDetails();
            Console.WriteLine();
        }
    }

    // Add Animal
    public void AddAnimal()
    {
        Console.WriteLine("Enter Animal ID:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Animal Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Animal Species:");
        string species = Console.ReadLine();

        Console.WriteLine("Enter Animal Health Status:");
        string healthStatus = Console.ReadLine();

        DateTime dateAdded = DateTime.Now;

        Animal animal = new Animal(id, name, species, healthStatus, dateAdded);
        AddEntity(animal);
        Console.WriteLine("Animal added successfully!\n");
    }

    // Feed Animal
    public void FeedAnimal()
    {
        Console.WriteLine("Enter the ID of the animal to feed:");
        int id = int.Parse(Console.ReadLine());

        foreach (var entity in entities)
        {
            if (entity is Animal animal && animal.ID == id)
            {
                animal.Feed();
                return;
            }
        }
        Console.WriteLine("Animal not found.\n");
    }

    // Remove Animal
    public void RemoveAnimal()
    {
        Console.WriteLine("Enter the ID of the animal to remove:");
        int id = int.Parse(Console.ReadLine());

        var animalToRemove = entities.Find(entity => entity is Animal animal && animal.ID == id);

        if (animalToRemove != null)
        {
            entities.Remove(animalToRemove);
            Console.WriteLine($"Animal with ID {id} has been removed.\n");
        }
        else
        {
            Console.WriteLine($"No animal found with ID {id}.\n");
        }
    }

    // Add Crop
    public void AddCrop()
    {
        Console.WriteLine("Enter Crop ID:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Crop Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Crop Type:");
        string type = Console.ReadLine();

        Console.WriteLine("Enter Crop Growth Stage:");
        string growthStage = Console.ReadLine();

        Crop crop = new Crop(id, name, type, growthStage);
        AddEntity(crop);
        Console.WriteLine("Crop added successfully!\n");
    }

    // Remove Crop
    public void RemoveCrop()
    {
        Console.WriteLine("Enter the ID of the crop to remove:");
        int id = int.Parse(Console.ReadLine());

        var cropToRemove = entities.Find(entity => entity is Crop crop && crop.ID == id);

        if (cropToRemove != null)
        {
            entities.Remove(cropToRemove);
            Console.WriteLine($"Crop with ID {id} has been removed.\n");
        }
        else
        {
            Console.WriteLine($"No crop found with ID {id}.\n");
        }
    }

    // Add Machinery
    public void AddMachinery()
    {
        Console.WriteLine("Enter Machinery ID:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Machinery Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Machinery Type:");
        string type = Console.ReadLine();

        Console.WriteLine("Enter Machinery Usage Status:");
        string usageStatus = Console.ReadLine();

        Equipment equipment = new Equipment(id, name, type, usageStatus);
        AddEntity(equipment);
        Console.WriteLine("Machinery added successfully!\n");
    }

    // Remove Machinery
    public void RemoveMachinery()
    {
        Console.WriteLine("Enter the ID of the machinery to remove:");
        int id = int.Parse(Console.ReadLine());

        var machineryToRemove = entities.Find(entity => entity is Equipment equipment && equipment.ID == id);

        if (machineryToRemove != null)
        {
            entities.Remove(machineryToRemove);
            Console.WriteLine($"Machinery with ID {id} has been removed.\n");
        }
        else
        {
            Console.WriteLine($"No machinery found with ID {id}.\n");
        }
    }

    // Add Employee
    public void AddEmployee()
    {
        Console.WriteLine("Enter Employee ID:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Employee Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Employee Role:");
        string role = Console.ReadLine();

        Console.WriteLine("Enter Hours Worked:");
        double hoursWorked = double.Parse(Console.ReadLine());

        Employee employee = new Employee(id, name, role, hoursWorked);
        AddEntity(employee);
        Console.WriteLine("Employee added successfully!\n");
    }

    // Remove Employee
    public void RemoveEmployee()
    {
        Console.WriteLine("Enter the ID of the employee to remove:");
        int id = int.Parse(Console.ReadLine());

        var employeeToRemove = entities.Find(entity => entity is Employee employee && employee.ID == id);

        if (employeeToRemove != null)
        {
            entities.Remove(employeeToRemove);
            Console.WriteLine($"Employee with ID {id} has been removed.\n");
        }
        else
        {
            Console.WriteLine($"No employee found with ID {id}.\n");
        }
    }

    // Display all animals
    public void DisplayAllAnimals()
    {
        Console.WriteLine("\nAll Animals:");
        foreach (var entity in entities)
        {
            if (entity is Animal animal)
            {
                animal.DisplayDetails();
            }
        }
    }

    // Display all crops
    public void DisplayAllCrops()
    {
        Console.WriteLine("\nAll Crops:");
        foreach (var entity in entities)
        {
            if (entity is Crop crop)
            {
                crop.DisplayDetails();
            }
        }
    }

    // Display all machinery
    public void DisplayAllMachinery()
    {
        Console.WriteLine("\nAll Machinery:");
        foreach (var entity in entities)
        {
            if (entity is Equipment equipment)
            {
                equipment.DisplayDetails();
            }
        }
    }

    // Display all employees
    public void DisplayAllEmployees()
    {
        Console.WriteLine("\nAll Employees:");
        foreach (var entity in entities)
        {
            if (entity is Employee employee)
            {
                employee.DisplayDetails();
            }
        }
    }

    public void DisplayCropGrowthStatuses()
    {
        Console.WriteLine("\nCrop Growth Statuses:");
        foreach (var entity in entities)
        {
            if (entity is Crop crop)
            {
                Console.WriteLine($"- {crop.Name} ({crop.Type}): Growth Stage - {crop.GrowthStage}");
            }
        }
    }

    public void DisplayAnimalHealthStatuses()
    {
        Console.WriteLine("\nAnimal Health Statuses:");
        foreach (var entity in entities)
        {
            if (entity is Animal animal)
            {
                Console.WriteLine($"- {animal.Name} ({animal.Species}): Health Status - {animal.HealthStatus}");
            }
        }
    }

    public void DisplayMachineryStatuses()
    {
        Console.WriteLine("\nMachinery Usage Statuses:");
        foreach (var entity in entities)
        {
            if (entity is Equipment equipment)
            {
                Console.WriteLine($"- {equipment.Name} ({equipment.Type}): Usage Status - {equipment.UsageStatus}");
            }
        }
    }

    public void DisplayEmployeeRoles()
    {
        Console.WriteLine("\nEmployee Roles:");
        foreach (var entity in entities)
        {
            if (entity is Employee employee)
            {
                Console.WriteLine($"- {employee.Name} (ID: {employee.ID}): Role - {employee.Role}, Hours Worked - {employee.HoursWorked}");
            }
        }
    }

       public void FeedAllAnimals()
    {
        Console.WriteLine("Enter the ID of the animal(s) to feed:");
        int id = int.Parse(Console.ReadLine());

        var animalsToFeed = entities.Where(entity => entity is Animal animal && animal.ID == id).Cast<Animal>().ToList();

        if (animalsToFeed.Count > 0)
        {
            foreach (var animal in animalsToFeed)
            {
                animal.Feed();
            }
            Console.WriteLine($"{animalsToFeed.Count} animal(s) with ID {id} have been fed.\n");
        }
        else
        {
            Console.WriteLine($"No animals found with ID {id}.\n");
        }
    }

    public void WaterCrops()
    {
        Console.WriteLine("Enter the ID of the crop(s) to water:");
        int id = int.Parse(Console.ReadLine());

        var cropsToWater = entities.Where(entity => entity is Crop crop && crop.ID == id).Cast<Crop>().ToList();

        if (cropsToWater.Count > 0)
        {
            foreach (var crop in cropsToWater)
            {
                Console.WriteLine($"Crop {crop.Name} (ID {id}) has been watered.");
                // Optionally, you could update crop status here, e.g., crop.LastWatered = DateTime.Now;
            }
            Console.WriteLine($"{cropsToWater.Count} crop(s) with ID {id} have been watered.\n");
        }
        else
        {
            Console.WriteLine($"No crops found with ID {id}.\n");
        }
    }

}