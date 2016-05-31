using System.IO;
using System.Net;
using Newtonsoft.Json;
using System;
using System.Xml.Linq;
using System.Linq;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var message = new StreamReader(responseStream).ReadToEnd();
                var stations = JsonConvert.DeserializeObject<Stations>(message);
                return stations;
            }

            return null;
        }

        public StationBoardRoot GetStationBoard(string station, string id)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?Station=" + station + "&id=" + id);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }

        public Connections GetConnections(string fromStation, string toStattion)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
                return connections;
            }

            return null;
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;

            return request;
        }

        public Connections GetConnectionsviaDate(string fromStation, string toStattion, DateTime date, DateTime time)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStattion + "&date=" + date.ToString("yyyy-MM-dd") + "&time=" + time.ToString("HH:mm"));
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
                return connections;
            }

            return null;
        }

        public StationBoardRoot GetStationBoardviaDateTime(string station, string id, DateTime date, DateTime time)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?station=" + station + "&datetime=" + date.ToString("yyyy-MM-dd") + time.ToString("HH:mm"));
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }

        public Stations getNearestStation(double x, double y)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?x=" + x + "&y=" + y);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var station =
                    JsonConvert.DeserializeObject<Stations>(readToEnd);
                return station;
            }

            return null;
        }

        public string getCoordinates(string address)
        {
            var request = CreateWebRequest("http://maps.googleapis.com/maps/api/geocode/xml?sensor=false&address=" + address);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            XDocument document = XDocument.Load(new StreamReader(responseStream));

            XElement longitudeElement = document.Descendants("lng").FirstOrDefault();
            XElement latitudeElement = document.Descendants("lat").FirstOrDefault();

            if (longitudeElement != null && latitudeElement != null)
            {
                return latitudeElement.Value.ToString() + ", " + longitudeElement.Value.ToString();
            }

            return null;
        }
    }
}
