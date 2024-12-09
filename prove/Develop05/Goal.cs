public abstract class Goal
{
    // Attributes (encapsulation with private fields)
    private string _name;
    private string _description;
    private int _points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Properties
    public string Name => _name;
    public string Description => _description;
    public int Points => _points;

    // Abstract Methods (polymorphism)
    public abstract int RecordEvent();
    public abstract string DisplayProgress();
    public virtual bool IsComplete() => false; // Virtual method for optional override
}
