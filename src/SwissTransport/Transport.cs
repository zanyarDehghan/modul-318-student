using System.IO;
using System.Net;
using Newtonsoft.Json;


namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query, double x, double y)
        {
            string url = "";
            if (query != "NULL")
            {
                 url = "http://transport.opendata.ch/v1/locations?query=" + query;
            }
            else
            {
                 url = "http://transport.opendata.ch/v1/locations?x=" + x +"&y="+y;
            }
            var request = CreateWebRequest(url);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var message = new StreamReader(responseStream).ReadToEnd();
                if (message != null)
                {
                    var stations = JsonConvert.DeserializeObject<Stations>(message);
                    return stations;
                }
                else
                {
                    
                }

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
    }
}
