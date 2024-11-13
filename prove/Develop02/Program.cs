using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal(); // this creates a new instance of the class Journal.
        while (true)
        {

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            string userChoice = Console.ReadLine();
            int choice = int.Parse(userChoice);



            if (choice == 1)
            {
                Entry entry = new Entry(); //This creates a new instance of the class Entry
                entry.AddEntry();
                myJournal.AddNewEntryToList(entry);
            }

            else if (choice == 2)
            {
                myJournal.DisplayEntries();
            }

            else if (choice == 3)
            {
                myJournal.ReadFromFile();
                myJournal.DisplayEntries();
            }

            else if (choice == 4)
            {
                myJournal.SaveToFile();
                Console.WriteLine("Journal saved to Journal.csv");
            }

            else if (choice == 5)
            {
                break;
            }
        }
    }
}


//  *****************NOTES********************

//Menu
//  Data
//      User choice
//  Methods
//      Display menu 

//Entry
//  Data
//      DataTime
//      Entry
//  Methods
//      Add entry
//Prompts 
//The Journal 
//  Named Journal
//  Data
//      List<entry> _entries
//      
//  Methods
//      Create a new entry
//      Write entry to file
//      Save to file
//      Read file 
//      Display all entries

// Please select one of the following choices:
// 1. Write
// 2. Read 
// 3. Load
// 4. Save
// 5. Exit
// 1
// What goals do you have for tomorrow?
// Get the frick out of bed!!
// ***Entries added to the list***
// Please select one of the following choices:
// 1. Write
// 2. Read
// 3. Load
// 4. Save
// 5. Exit
// 1
// What was the highlight of your week?
// Seeing Lauren
// ***Entries added to the list***
// Please select one of the following choices:
// 1. Write
// 2. Read
// 3. Load
// 4. Save
// 5. Exit
// 4
// ***Journal saved to file.***
// Journal saved to Journal.csv
// Please select one of the following choices:
// 1. Write
// 2. Read
// 3. Load
// 4. Save
// 5. Exit
// 2
// ***No entries to display.***
// Please select one of the following choices:
// 1. Write
// 2. Read
// 3. Load
// 4. Save
// 5. Exit
// 3
// ***All entries have been added from the file***
// Date: 11/12/2024
// Prompt: What goals do you have for tomorrow?
// Response: Get the frick out of bed!!

// Date: 11/12/2024
// Prompt: What was the highlight of your week?
// Response: Seeing Lauren

// ***DisplayEntries function ran***
// Please select one of the following choices:
// 1. Write
// 2. Read
// 3. Load
// 4. Save
// 5. Exit
// 2
// Date: 11/12/2024
// Prompt: What goals do you have for tomorrow?
// Response: Get the frick out of bed!!

// Date: 11/12/2024
// Prompt: What was the highlight of your week?
// Response: Seeing Lauren

// ***DisplayEntries function ran***
// Please select one of the following choices:
// 1. Write
// 2. Read
// 3. Load
// 4. Save
// 5. Exit
// 1
// What was your favorite thing that you did today?
// I walked in the snow
// ***Entries added to the list***
// Please select one of the following choices:
// 1. Write
// 2. Read
// 3. Load
// 4. Save
// 5. Exit
// 2
// Date: 11/12/2024
// Prompt: What goals do you have for tomorrow?
// Response: Get the frick out of bed!!

// Date: 11/12/2024
// Prompt: What was the highlight of your week?
// Response: Seeing Lauren

// Date: 11/12/2024
// Prompt: What was your favorite thing that you did today?
// Response: I walked in the snow

// ***DisplayEntries function ran***
// Please select one of the following choices:
// 1. Write
// 2. Read
// 3. Load
// 4. Save
// 5. Exit