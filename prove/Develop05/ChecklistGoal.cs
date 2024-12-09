public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public int TargetCount => _targetCount;
    public int CurrentCount => _currentCount;
    public int BonusPoints => _bonusPoints;

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                return Points + _bonusPoints; // Bonus on completion
            }
            return Points; // Points per event
        }
        return 0; // No points if already complete
    }

    public override string DisplayProgress()
    {
        return $"[{(_currentCount == _targetCount ? "X" : " ")}] {Name} (Completed {_currentCount}/{_targetCount} times)";
    }

    public override bool IsComplete() => _currentCount >= _targetCount;
}
