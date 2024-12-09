public class Employee : FarmEntity
{
    public string Role;
    public double HoursWorked;

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Role: {Role}, Hours Worked: {HoursWorked}");
    }
}