public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0; // No points if already complete
    }

    public override string DisplayProgress()
    {
        return $"[{(_isComplete ? "X" : " ")}] {Name}";
    }

    public override bool IsComplete() => _isComplete;
}