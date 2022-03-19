namespace SwissTransport.Core
{
    using System.Threading.Tasks;

    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoard(string station, string id);
        StationBoardRoot GetStationBoard(string station, string id, string dateStation);

        Connections GetConnections(string fromStation, string toStation);
        Connections GetConnections(string fromStation, string toStation, string dateStation, string timeStation);
    }
}