﻿namespace SwissTransport
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SwissTransport.Core;

    /// <summary>
    /// The Swiss Transport API tests.
    /// </summary>
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = this.testee.GetStations("Sursee,");

            Assert.AreEqual(10, stations.StationList.Count);
        }

        [TestMethod]
        public void StationBoard()
        {
            testee = new Transport();
            var stationBoard = this.testee.GetStationBoard("Sursee", "8502007");

            Assert.IsNotNull(stationBoard);
        }

        [TestMethod]
        public void Connections()
        {
            testee = new Transport();
            var connections = this.testee.GetConnections("Sursee", "Luzern");

            Assert.IsNotNull(connections);
        }
        
        [TestMethod]
        public void TimeTable()
        {
          testee = new Transport();
          var connections = this.testee.GetConnections("Sursee", "Luzern");

          Assert.AreEqual(4, connections.ConnectionList.Count);
        }
        
        [TestMethod]
        public void DateConenctions()
         {
            testee = new Transport();
            var connections = this.testee.GetConnections("Luzern", "Bern", "2021-05-13", "22:05");
            Assert.IsNotNull(connections);
         }
    }
}