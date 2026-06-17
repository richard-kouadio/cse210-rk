class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();
        gm.Start();
    }
}

/*
EXCEEDING REQUIREMENTS:

This program extends the core requirements by introducing gamification elements
to enhance user engagement and motivation.

- Implemented a persistent scoring system that tracks user progress across all goals.
- Added a dynamic level system where users level up every 1000 points earned.
- Enhanced the user experience by displaying real-time score and level feedback.
- Designed the application to feel more like a progression-based game rather than
  a simple tracker, encouraging consistent interaction and long-term goal completion.
*/