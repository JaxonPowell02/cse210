using System;

class Program
{
    static void Main(string[] args)
    {
        string UserInput = "Run";

        Reference scriptureVerse = new Reference();
        Word wordProcessor = new Word();
        Scripture scripture = new Scripture();

        string ChosenScriptureVerse = scriptureVerse.GetReferenceAndScripture();
        Console.Clear();
        scripture.DisplayScripture(ChosenScriptureVerse);

        Console.ReadLine();

        int totalWords = ChosenScriptureVerse.Split(' ').Length;
        int wordsReplaced = 0;



        while (wordsReplaced< totalWords && UserInput != "quit")
        {
            string scriptureChecker = ChosenScriptureVerse;
            ChosenScriptureVerse = wordProcessor.RemoveWord(ChosenScriptureVerse);
            Console.Clear();
            if (scriptureChecker != ChosenScriptureVerse)
            {
                wordsReplaced++;
            }
            
            Console.WriteLine(ChosenScriptureVerse);

            if (ChosenScriptureVerse.Replace("_", "").Trim().Length == 0)
            {
                break;
            }
            UserInput = Console.ReadLine();
        }

    }
}