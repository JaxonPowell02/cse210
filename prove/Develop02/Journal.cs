using System.IO; 

class Journal
{

    public List<Entry> Entries = new List<Entry>(); //This creates a new list

    public void AddNewEntryToList(Entry entry)
    {
        Entries.Add(entry);
        // Console.WriteLine("***Entries added to the list***");
    }

    public void DisplayEntries()
    {
        if (Entries.Count == 0)
        {
            // Console.WriteLine("***No entries to display.***");
            return;
        }

        foreach (Entry entry in Entries)
        {
            Console.WriteLine(entry.DisplayJournal());
            
        }
        // Console.WriteLine("***DisplayEntries function ran***");
    }

    public void SaveToFile()
    {

        using (StreamWriter outputFile = new StreamWriter("journal.csv"))
            {
                foreach (Entry entry in Entries)
                {
                    outputFile.WriteLine(entry.ToString());
                }
            }
        // Console.WriteLine("***Journal saved to file.***");
        Entries = []; //This clears the list that you all ready have so when you save to the file and then 
                      //load from the file you dont have duplicate entries.
    }

    public void ReadFromFile()
    {
        string filename = "journal.csv";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry(); //This creates a new instance of the class Entry


            entry.SetDate(parts[0]);
            entry.SetPrompt(parts[1]);
            entry.SetResponse(parts[2]);
            Entries.Add(entry);

        }
        // Console.WriteLine("***All entries have been added from the file***");
    }



}