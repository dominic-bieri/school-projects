using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SuperLeague
{
    public class Table
    {
        public List<TableRow> TableRows { get; set; }

        public Table(List<TableRow> rows)
        {
            TableRows = rows;
        }
        /// <summary>
        /// Creates TableRows + Calculation of TableRows
        /// </summary>
        /// <param name="matches"></param>
        /// <returns>Table with List of TableRows</returns>
        public static Table CreateTable(List<Match> matches)
        {
            Dictionary<string, TableRow> tableRows = new Dictionary<string, TableRow>();

            foreach (Match match in matches)
            {
                string homeTeam = match.homeTeam;
                string awayTeam = match.awayTeam;

                if (!tableRows.ContainsKey(homeTeam))
                {
                    tableRows.Add(homeTeam, new TableRow(homeTeam));
                }

                if (!tableRows.ContainsKey(awayTeam))
                {
                    tableRows.Add(awayTeam, new TableRow(awayTeam));
                }

                tableRows[homeTeam].GoalsScored += match.homeGoals;
                tableRows[awayTeam].GoalsScored += match.awayGoals;
                tableRows[homeTeam].GoalsReceived += match.awayGoals;
                tableRows[awayTeam].GoalsReceived += match.homeGoals;

                if (match.homeGoals > match.awayGoals)   // Win for Home-Team
                {
                    tableRows[homeTeam].Wins++;
                    tableRows[awayTeam].Loses++;
                }

                else if (match.homeGoals < match.awayGoals)  // Win for Away-Team
                {
                    tableRows[homeTeam].Loses++;
                    tableRows[awayTeam].Wins++;
                }

                else            // Draw
                {
                    tableRows[homeTeam].Draws++;
                    tableRows[awayTeam].Draws++;
                }
            }
            return new Table(new List<TableRow>(tableRows.Values));
        }

        public void SortTable()
        {
            // https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/working-with-linq
            TableRows = TableRows.OrderByDescending(o => o.Points).ThenByDescending(o => o.GoalsDifference).ThenByDescending(o => o.Wins).ThenBy(o => o.TeamName).ToList();
        }

        /// <summary>
        /// Creates Table in String-Format
        /// </summary>
        /// <returns>Sorted Table in String-Format</returns>
        public override string ToString()
        {
            SortTable();

            int position = 1;
            StringWriter output = new StringWriter();
            output.WriteLine("{0, -30} {1, 5} {2, 5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 7} {8, 5}",
              "Team", "#", "w", "d", "l", "+", "-", "=", "p");
            output.WriteLine("---------------------------------------------------------------------------------");

            if (TableRows.Count() == 0)
            {
                throw new ArgumentException("No teams available!!");
            }

            foreach (TableRow row in TableRows)
            {
                output.WriteLine($"{row.TeamName,-30} {position,5} {row.Wins,5} {row.Draws,5} {row.Loses,5} {row.GoalsScored,5} {row.GoalsReceived,5} {row.GoalsDifference,7} {row.Points,5}");
                position++;
            }
            return output.ToString();
        }
    }
}
