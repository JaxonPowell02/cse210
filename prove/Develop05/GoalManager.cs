using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalScore;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        DisplayGoals();
        
        var goal = _goals.FirstOrDefault(g => g.Name == goalName);
        if (goal != null)
        {
            _totalScore += goal.RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.DisplayProgress());
        }
        Console.WriteLine($"Total Score: {_totalScore}");
    }

    public void DisplayTotalScore()
    {
        Console.WriteLine($"\nTotal Score: {_totalScore}\n");
    }

    public void SaveGoals(string filePath)
    {
        string fileName = filePath;
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"Total Score: {_totalScore}");


            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal simpleGoal)
                {
                    outputFile.WriteLine($"SimpleGoal|{simpleGoal.Name}|{simpleGoal.Description}|{simpleGoal.Points}|{simpleGoal.IsComplete()}");
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    outputFile.WriteLine($"EternalGoal|{eternalGoal.Name}|{eternalGoal.Description}|{eternalGoal.Points}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    outputFile.WriteLine($"ChecklistGoal|{checklistGoal.Name}|{checklistGoal.Description}|{checklistGoal.Points}|{checklistGoal.IsComplete()}|{checklistGoal.TargetCount}|{checklistGoal.CurrentCount}|{checklistGoal.BonusPoints}");
                }
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        using (StreamReader inputFile = new StreamReader(filePath))
        {
            string totalScoreLine = inputFile.ReadLine();
            _totalScore = int .Parse(totalScoreLine.Split(':')[1]);

            _goals.Clear();

            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string goalType = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (goalType == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    if (isComplete)
                    {
                        simpleGoal.RecordEvent();
                    }
                    _goals.Add(simpleGoal);
                }
                else if (goalType == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                }
                else if (goalType == "ChecklistGoal")
                {
                    int targetCount = int.Parse(parts[5]);
                    int currentCount = int.Parse(parts[6]);
                    int bonusPoints = int.Parse(parts[7]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                    for (int i = 0; i < currentCount; i ++)
                    {
                        checklistGoal.RecordEvent();
                    }
                    _goals.Add(checklistGoal);
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}
