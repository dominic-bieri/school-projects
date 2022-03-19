using System;
using Xunit;
using System.Collections.Generic;
using System.IO;

namespace SuperLeague.Tests
{
    public class TableTest
    {
        [Fact]
        public void TestTableToString()
        {
            // Arrange
            List<Match> matches = new List<Match>();
            matches.Add(new Match("FC Luzern", "FC Zürich", 3, 1));
            matches.Add(new Match("FC Lugano", "FC Zürich", 2, 1));
            matches.Add(new Match("FC Luzern", "FC Lugano", 1, 1));
            Table table = Table.CreateTable(matches);
            string result;
            string expected =
                "Team                               #     w     d     l     +     -       =     p\n" +
                "---------------------------------------------------------------------------------\n" +
                "FC Luzern                          1     1     1     0     4     2       2     4\n" +
                "FC Lugano                          2     1     1     0     3     2       1     4\n" +
                "FC Zürich                          3     0     0     2     2     5      -3     0\n"; ;

            // Act
            result = table.ToString();

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestTableToStringWithEmptyTable()
        {
            // Arrange
            List<Match> matches = new List<Match>();
            Table table = Table.CreateTable(matches);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => table.ToString());
        }

        [Fact]
        public void TestSortByPoints()
        {
            // Arrange
            List<Match> matches = new List<Match>();
            matches.Add(new Match("FCL", "FCB", 3, 0));
            Table result = Table.CreateTable(matches);

            int expected = 0;   // 1. in table

            // Act
            result.SortTable();

            // Assert
            Assert.Equal(expected, result.TableRows.FindIndex(team => team.TeamName == "FCL"));
        }

        [Fact]
        public void TestSortByGoalsDifference()
        {
            // Arrange
            List<Match> matches = new List<Match>();
            matches.Add(new Match("FCL", "FCB", 3, 0));
            matches.Add(new Match("FCZ", "FCB", 2, 0));
            Table result = Table.CreateTable(matches);

            int expected = 1;   // 2. in table

            // Act
            result.SortTable();

            // Assert
            Assert.Equal(expected, result.TableRows.FindIndex(team => team.TeamName == "FCZ"));
        }

        [Fact]
        public void TestSortByWins()
        {
            // Arrange
            List<Match> matches = new List<Match>();
            matches.Add(new Match("FCL", "FCB", 3, 0));
            matches.Add(new Match("FCZ", "FCB", 1, 1));
            matches.Add(new Match("FCZ", "FCC", 1, 1));
            matches.Add(new Match("FCZ", "FCD", 1, 1));
            Table result = Table.CreateTable(matches);

            int expected = 0;   // 1. in table

            // Act
            result.SortTable();

            // Assert
            Assert.Equal(expected, result.TableRows.FindIndex(team => team.TeamName == "FCL"));
        }

        [Fact]
        public void TestSortByName()
        {
            // Arrange
            List<Match> matches = new List<Match>();
            matches.Add(new Match("FCL", "FCB", 3, 0));
            matches.Add(new Match("FCZ", "FCC", 3, 0));
            matches.Add(new Match("FCA", "FCD", 3, 0));
            Table result = Table.CreateTable(matches);

            int expected = 0;   // 1. in table

            // Act
            result.SortTable();

            // Assert
            Assert.Equal(expected, result.TableRows.FindIndex(team => team.TeamName == "FCA"));
        }
    }
}