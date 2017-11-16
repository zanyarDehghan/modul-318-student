namespace SwissTransport
{
    public interface ITransport
    {

        Stations GetStations(string query, double x, double y);
        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, string toStattion);
    }
}