public class FarmEntity
{
    public int ID;
    public string Name;




    public virtual void DisplayDetails()
    {
        Console.WriteLine($"ID: {ID}, Name: {Name}");
    }
}