using System;
using System.Collections.Generic;
using Xunit;
using System.IO;
using System.Linq;

namespace SuperLeague.Tests
{
    public class TableRowTest
    {
        [Fact]
        public void TestPoints()
        {
            // Arrange & Act
            TableRow team1 = new TableRow("FC Luzern");
            team1.Wins = 4;
            team1.Draws = 2;
            team1.Loses = 1;
            int expected = 14;

            // Assert
            Assert.Equal(expected, team1.Points);
        }

        [Fact]
        public void TestTeamWins()
        {
            // Arrange
            List<Match> matches = new List<Match>();
            matches.Add(new Match("FCL", "GC", 2, 1));
            int expected = 1;

            // Act
            Table result = Table.CreateTable(matches);
            result.SortTable();

            // Assert
            Assert.Equal(expected, result.TableRows[result.TableRows.FindIndex(team => team.TeamName == "FCL")].Wins);
        }

        [Fact]
        public void TestTeamDraws()
        {
            // Arrange
            List<Match> matches = new List<Match>();
            matches.Add(new Match("FCZ", "GC", 0, 0));
            int expected = 1;

            // Act
            Table result = Table.CreateTable(matches);
            result.SortTable();

            // Assert
            Assert.Equal(expected, result.TableRows[result.TableRows.FindIndex(team => team.TeamName == "FCZ")].Draws);

        }

        [Fact]
        public void TestTeamLoses()
        {
            // Arrange
            List<Match> matches = new List<Match>();
            matches.Add(new Match("FCZ", "FCL", 0, 2));
            int expected = 1;

            // Act
            Table result = Table.CreateTable(matches);
            result.SortTable();

            // Assert
            Assert.Equal(expected, result.TableRows[result.TableRows.FindIndex(team => team.TeamName == "FCZ")].Loses);

        }

        [Fact]
        public void TestGoalsScored()
        {
            // Arrange
            List<Match> matches = new List<Match>();
            matches.Add(new Match("FCL", "FCZ", 5, 2));
            int expected = 5;

            // Act
            Table result = Table.CreateTable(matches);

            // Assert
            Assert.Equal(expected, result.TableRows[result.TableRows.FindIndex(team => team.TeamName == "FCL")].GoalsScored);
        }

        [Fact]
        public void TestGoalsReceived()
        {
            // Arrange
            List<Match> matches = new List<Match>();
            matches.Add(new Match("FCL", "FCZ", 5, 2));
            int expected = 2;

            // Act
            Table result = Table.CreateTable(matches);

            // Assert
            Assert.Equal(expected, result.TableRows[result.TableRows.FindIndex(team => team.TeamName == "FCL")].GoalsReceived);
        }

        [Fact]
        public void TestGoalsDifferencePositv()
        {
            // Arrange & Act
            TableRow team1 = new TableRow("FC Luzern");
            team1.GoalsScored = 5;
            team1.GoalsReceived = 2;
            int expected = 3;

            // Assert
            Assert.Equal(expected, team1.GoalsDifference);
        }

        [Fact]
        public void TestGoalsDifferenceNegativ()
        {
            // Arrange & Act
            TableRow team1 = new TableRow("FC Luzern");
            team1.GoalsScored = 2;
            team1.GoalsReceived = 5;
            int expected = -3;

            // Assert
            Assert.Equal(expected, team1.GoalsDifference);
        }
    }
}
