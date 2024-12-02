public class Activity
{
    public int Duration;
    private string Description;

    public Activity(string description, int duration)
    {
        Description = description;
        Duration = duration; // Duration is stored in seconds
    }

    public int GetDuration()
    {
        Console.WriteLine("Enter the duration for the activity (in seconds):");
        string input = Console.ReadLine();
        int userDuration = int.Parse(input); // Duration is input as seconds
        return userDuration;
    }

    public void Start()
    {
        Console.WriteLine("Starting activity...\n");
        Spinner(5000);
    }

    public void End()
    {
        Console.WriteLine("\nActivity completed!");
    }

    public void Pause(int seconds)
    {
        Thread.Sleep(seconds); 
    }

    public void Spinner(double seconds)
    {
        seconds = seconds / 1000;  
        int i = 0;

        do {

            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b");
            i += 2;
        } while (i <= seconds);
    }

    public void DisplayTimer(int remainingTime)
    {
        Console.WriteLine($"Time remaining: {remainingTime} seconds");
    }
}
