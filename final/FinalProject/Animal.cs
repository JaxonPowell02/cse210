public class Animal : FarmEntity
{
    public string Species;
    public string HealthStatus;
    public DateTime DateAdded;

    public Animal(int id, string name, string species, string healthStatus, DateTime dateAdded)
    {
        ID = id;
        Name = name;
        Species = species;
        HealthStatus = healthStatus;
        DateAdded = dateAdded;
    }


    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Species: {Species}, Health Status: {HealthStatus}");
    }

    public void Feed()
    {
        Console.WriteLine($"{Name} the {Species} has been fed.");
    }
}