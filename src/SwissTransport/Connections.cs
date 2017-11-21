using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Connections
    {
        [JsonProperty("connections")]
        public List<Connection> ConnectionList { get; set; }
    }

    public class Connection
    {
        [JsonProperty("from")]
        public ConnectionPoint From { get; set; }

        [JsonProperty("to")]
        public ConnectionPoint To { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("service")]
        public Service Service{get;set;}

        [JsonProperty("products")]
        public string[] Products { get; set; }

        [JsonProperty("capacity1st")]
        public string Capacity1st { get; set; }

        [JsonProperty("capacity2st")]
        public string Capacity2st { get; set; }

        [JsonProperty("sections")]
        public List<Sections> Sections { get; set; }

    }
    public class Service
    {
        [JsonProperty("regular")]
        public string Regular { get; set; }

        [JsonProperty("irregular")]
        public string Irregular { get; set; }
    }
    public class Sections
    {
        [JsonProperty("journey")]
        public Journey Journey { get; set; }

        [JsonProperty("walk")]
        public Walk Walk { get; set; }

        [JsonProperty("departure")]
        public Stop Departure { get; set; }

        [JsonProperty("arrival")]
        public Stop Arrival{ get; set; }
    }

    public class Walk{
        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class Journey
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("subcategory")]
        public string SubCategory { get; set; }

        [JsonProperty("categoryCode")]
        public string CategoryCode { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("passList")]
        public List<Stop> PassList { get; set; }
        

        [JsonProperty("capacity1st")]
        public string Capacity1st { get; set; }

        [JsonProperty("capacity2nd")]
        public string Capacity2nd { get; set; }

    }

    public class Stop
    {
        [JsonProperty("station")]
        public Location Station;

        [JsonProperty("arrival")]
        public string Arrival { get; set; }

        [JsonProperty("departure")]
        public string Departure { get; set; }

        [JsonProperty("delay")]
        public string Delay { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("prognosis")]
        public Prognosis Prognosis;
    }

    public class Prognosis
    {
        [JsonProperty("platform")]
        public string Platform;

        [JsonProperty("departure")]
        public string Departure { get; set; }

        [JsonProperty("arrival")]
        public string Arrival { get; set; }

        [JsonProperty("capacity1st")]
        public int? Capacity1st { get; set; }

        [JsonProperty("capacity2nd")]
        public int? Capacity2nd { get; set; }
    }

    public class Location
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name{get; set;}

        [JsonProperty("score")]
        public int? Score { get; set; }

        [JsonProperty("coordinate")]
        public Coordinate Coordinate { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }
    }

    public class ConnectionPoint
    {
        [JsonProperty("station")]
        public Station Station { get; set; }

        public string Arrival { get; set; }

        public string ArrivalTimestamp { get; set; }

        public string Departure { get; set; }

        public string DepartureTimestamp { get; set; }

        public int? Delay { get; set; }

        public string Platform { get; set; }

        public string RealtimeAvailability { get; set; }
    }

}