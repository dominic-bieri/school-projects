using System;
namespace SuperLeague
{
    public class TableRow
    {
        public string TeamName { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loses { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsReceived { get; set; }
        public int GoalsDifference { get { return GoalsScored - GoalsReceived; } }
        public int Points { get { return Wins * 3 + Draws; } }      // Wins = 3 P, Draws = 1 P

        public TableRow(string teamName)
        {
            TeamName = teamName;
            GoalsReceived = 0;
            GoalsScored = 0;
        }
    }
}
