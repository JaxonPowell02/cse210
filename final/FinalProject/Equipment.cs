public class Equipment : FarmEntity
{
    public string Type { get; set; }
    public string UsageStatus { get; set; }

    // Constructor with four arguments
    public Equipment(int id, string name, string type, string usageStatus)
    {
        ID = id;
        Name = name;
        Type = type;
        UsageStatus = usageStatus;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Type: {Type}, Usage Status: {UsageStatus}\n");
    }
}
