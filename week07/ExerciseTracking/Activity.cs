public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    // REQUIRED: abstract methods (rubric requirement #4)
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // REQUIRED: MUST NOT be overridden (rubric #5)
    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) - " +
               $"Distance {GetDistance():F2}, Speed {GetSpeed():F2}, Pace: {GetPace():F2}";
    }
}