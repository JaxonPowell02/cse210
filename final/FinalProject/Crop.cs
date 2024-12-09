public class Crop : FarmEntity
{
    public string Type;
    public string GrowthStage;

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Type: {Type}, Growth Stage: {GrowthStage}");
    }

    public void Water()
    {
        Console.WriteLine($"{Name} (Crop) has been watered.");
    }
}