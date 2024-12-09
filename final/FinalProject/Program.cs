
public class Program
{
    public static void Main()
    {
        Menu menu = new Menu();
        
        while (true)
        {

            int value = menu.MainMenu();

            switch (value)
            {
                case 1: 
                    AddAnimal();

                    break;
            }



            FarmManager farmManager = new FarmManager();

            // Add animals
            Animal cow = new Animal { ID = 1, Name = "Bessie", DateAdded = DateTime.Now, Species = "Cow", HealthStatus = "Healthy" };
            farmManager.AddEntity(cow);

            // Add crops
            Crop wheat = new Crop { ID = 2, Name = "Wheat", DateAdded = DateTime.Now, Type = "Grain", GrowthStage = "Early" };
            farmManager.AddEntity(wheat);

            // Add equipment
            Equipment tractor = new Equipment { ID = 3, Name = "Tractor", DateAdded = DateTime.Now, Type = "Machinery", UsageStatus = "Available" };
            farmManager.AddEntity(tractor);

            // Add employee
            Employee worker = new Employee { ID = 4, Name = "John", DateAdded = DateTime.Now, Role = "Farmhand", HoursWorked = 120.5 };
            farmManager.AddEntity(worker);

            // View all entities
            farmManager.ViewAllEntities();

            // Specific actions
            cow.Feed();
            wheat.Water();
        }
    }

public static void AddAnimal()
{
    Console.WriteLine("ID number: ");
    int id = int.Parse(Console.ReadLine());

    Console.WriteLine("Animal Name: ");
    string animalName = Console.ReadLine();

    Console.WriteLine("Species: ");
    string animalSpecies = Console.ReadLine();

    Console.WriteLine("Health Status: ");
    string animalHealthStatus = Console.ReadLine();

    DateTime dateAdded = DateTime.Now;

    Animal newAnimal = new Animal(id, animalName, animalSpecies, animalHealthStatus, dateAdded);
    FarmManager.AddEntity(animalSpecies);
    // Add the new animal to your animal list or database here
    // For example: animalList.Add(newAnimal);
}


}
