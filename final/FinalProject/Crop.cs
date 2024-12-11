public class Crop : FarmEntity
{
    public string Type { get; set; }
    public string GrowthStage { get; set; }

    // Constructor with four arguments
    public Crop(int id, string name, string type, string growthStage)
    {
        ID = id;
        Name = name;
        Type = type;
        GrowthStage = growthStage;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Type: {Type}, Growth Stage: {GrowthStage}\n");
    }



}
