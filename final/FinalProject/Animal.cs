public class Animal : FarmEntity
{
    public string Species { get; set; }
    public string HealthStatus { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime? LastFed { get; private set; } // Nullable to indicate it may not have been fed yet

    // Constructor
    public Animal(int id, string name, string species, string healthStatus, DateTime dateAdded)
    {
        ID = id;
        Name = name;
        Species = species;
        HealthStatus = healthStatus;
        DateAdded = dateAdded;
        LastFed = null; // Initially, the animal has not been fed
    }

    // Display details about the animal
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Species: {Species}, Health Status: {HealthStatus}, Date Added: {DateAdded}");
        if (LastFed.HasValue)
        {
            Console.WriteLine($"Last Fed: {LastFed.Value}\n");
        }
        else
        {
            Console.WriteLine("Last Fed: Never");
        }
    }

    // Feed method
    public void Feed()
    {
        LastFed = DateTime.Now; // Update LastFed with the current time
        Console.WriteLine($"{Name} the {Species} has been fed at {LastFed.Value}.\n");
    }
}
