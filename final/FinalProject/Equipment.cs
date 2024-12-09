public class Equipment : FarmEntity
{
    public string Type;
    public string UsageStatus;

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Type: {Type}, Usage Status: {UsageStatus}");
    }
}