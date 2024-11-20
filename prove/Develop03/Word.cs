
class Word
{

    public string RemoveWord(string ChosenScriptureVerse)
    {
        Random random = new Random();
        string[] words = ChosenScriptureVerse.Split(' ');

        int randomNum;
        string removedWord;

        do 
        {
            randomNum = random.Next(words.Length);
            removedWord = words[randomNum];
        } while (removedWord.Contains('_'));


        int letterCount = GetLetter(removedWord);
        string underscores = new string('_', letterCount);
        words[randomNum] = underscores;


        string ChangedList = string.Join(" ", words).Trim();
        return ChangedList;
    }

    private int GetLetter(string RemovedWord)
    {
        int letterCount = 0;
        foreach(char letter in RemovedWord)
        {
            letterCount ++;

        }
        
        return letterCount;
    }

}