public class Breathing : Activity
{
    public Breathing(string description, int duration) : base(description, duration)
    {
    }

    private void CountDown()
    {

    }
    public void Run(int duration)
    {
        Start(); // Call Start from Activity class
        Console.WriteLine("Breathing Activity: Focus on your breathing");

        for (int i = 0; i < duration; i += 10)
        {
            // Console.WriteLine("For loop is running");
            BreatheIn("Breathe in... ");  // 4 seconds
            BreatheOut("Breathe out... "); // 6 seconds
        }

        End(); // Call End from Activity class
    }

    private void BreatheIn(string instruction)
    {
        Console.Write($"{instruction}");
        // Console.WriteLine("Breathe in is running");
        for (int j = 4; j >= 1; j -= 1)
        {
            // Console.WriteLine("Breathe in for loop running");
            
            Console.Write($"{j}");
            Pause(1000);
            Console.Write("\b \b"); 
            // Console.Write($"{j}");
            // Console.WriteLine($"{instruction}");

             // Use Pause from Activity class
            
        }
        Console.WriteLine("");

    }
    private void BreatheOut(string instruction)
    {
        Console.Write($"{instruction}");
        // Console.WriteLine("Breathe out is running");
        for (int f = 0; f < 6; f += 1)
        {
            // Console.WriteLine("Breathe out for loop running");
            Console.Write($"{f}");
            Pause(1000);
            Console.Write("\b \b"); 
            // Console.Clear();
            // Console.Write("\b \b"); 
            // Console.Write($"{f}");

        }
        Console.WriteLine("");
    }
}


// Console.Write("+");

// Thread.Sleep(500);

// Console.Write("\b \b"); // Erase the + character
// Console.Write("-"); // Replace it with the - character