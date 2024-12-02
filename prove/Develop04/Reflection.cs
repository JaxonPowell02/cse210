class Reflection : Activity
{

        public Reflection(string description, int duration) : base(description, duration)
    {
    }
    private string[] Prompts = {
        "Think of a moment that made you feel peaceful",
        "Recall a time when you overcame a challenge",
        "Remember a moment of kindness you experienced",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] ReflectionQuestions = {
        "How did this moment make you feel?",
        "What did you learn from this experience?",
        "How can you bring more of this feeling into your life?",
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void Run()
    {
        Start("reflecting activity");
        Console.WriteLine("Reflection Activity: Explore your inner thoughts\n");

        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Length)];

        
        Console.WriteLine(prompt);
        Spinner(9000);

        for (int i = 0; i < Duration; i += 15)
        {   
            Random random1 = new Random();
            string Question = ReflectionQuestions[random.Next(ReflectionQuestions.Length)];
            Console.WriteLine($"{Question}");
            Spinner(15000);
        }

        End();
    }
}