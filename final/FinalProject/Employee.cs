public class Employee : FarmEntity
{
    public string Role { get; set; }
    public double HoursWorked { get; set; }

    public Employee(int id, string name, string role, double hoursWorked)
    {
        ID = id;
        Name = name;
        Role = role;
        HoursWorked = hoursWorked;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Role: {Role}, Hours Worked: {HoursWorked}\n");
    }
}
