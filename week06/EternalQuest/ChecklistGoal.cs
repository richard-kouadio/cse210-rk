public class ChecklistGoal : Goal
{
    private int _completed;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int completed, int target, int bonus)
        : base(name, description, points)
    {
        _completed = completed;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_completed >= _target)
            return 0;

        _completed++;

        if (_completed == _target)
            return _points + _bonus;

        return _points;
    }

    public override bool IsComplete() => _completed >= _target;

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} - {_description} ({_completed}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_completed}|{_target}|{_bonus}";
    }
}