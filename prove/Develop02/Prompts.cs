using System;

class Prompts
{
    private static string[] prompts = new string[]
    {
        "What was the most exciting thing of your day?",
        "What did you learn today?",
        "What was the highlight of your week?",
        "What are you grateful for today?",
        "What goals do you have for tomorrow?",
        "Who was the most interesting person you talked to today?",
        "What was your favorite part of the day?",
        "What was your favorite thing that you did today?",
        "What is one thing that you want to remember from today?",
        "What did you learn today?"
    };

    public static string getPrompt()
    {
        Random random = new Random();
        int RandomIndex = random.Next(prompts.Length);
        return prompts[RandomIndex];
    }

    public static string PrintPrompt()
    {
        string prompt = getPrompt();
        return prompt;
    }
}
