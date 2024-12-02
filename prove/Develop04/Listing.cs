 class Listing : Activity
{

        public Listing(string description, int duration) : base(description, duration)
    {
    }

        private string[] Prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
    };

    public void Run()
    {
        Start();
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Length)];
        Console.WriteLine(prompt);
        Spinner(9000);

        List<string> items = new List<string>();
        Console.WriteLine("Start listing items. Press Enter after each item.");
        Thread.Sleep(2000);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(Duration);
        DateTime currentTime = DateTime.Now;
        do{
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
            currentTime = DateTime.Now;
            
        } while (currentTime < futureTime);

        Console.WriteLine($"You listed {items.Count} items.");
        End();
    }
}
