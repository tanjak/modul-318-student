using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoardviaDateTime(string station, string id, DateTime date, DateTime time);
        Connections GetConnectionsviaDate(string fromStation, string toStattion, DateTime date, DateTime time);
        Stations getNearestStation(double x, double y);
        string getCoordinates(string address);
    }
}