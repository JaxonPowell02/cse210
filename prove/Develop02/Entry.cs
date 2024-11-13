
using System;

class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    //Constructor that will set the correct values when reading from a file.
    public void SetDate(string date)
    {
        _date = date;
    }
    public void SetPrompt(string prompt)
    {
        _prompt = prompt;
    }
    public void SetResponse(string response) 
    {
        _response = response;
    }


    public void AddEntry()
    {
        _date = GetDateTime();
        _prompt = Prompts.PrintPrompt();

        Console.WriteLine(_prompt);
        Console.Write("");
        _response = Console.ReadLine();

        // string usedPrompt = Prompts.PrintPrompt();
        // Console.WriteLine(Prompts.PrintPrompt());
        // Console.Write("");
        // _entry = Console.ReadLine();        
        // Console.WriteLine(_entry);
    }

    public string GetDateTime()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        // Console.WriteLine(dateText);
        return dateText;
    }

    public override string ToString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    public string DisplayJournal()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");

        return "";
    }
}


