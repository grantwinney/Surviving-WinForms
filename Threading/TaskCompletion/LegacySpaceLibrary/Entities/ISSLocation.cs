using Newtonsoft.Json;

namespace LegacySpaceLibrary
{
    public class ISSLocation
    {
        [JsonProperty("message")]
        public string Message { get; private set; }

        [JsonProperty("iss_position")]
        public ISSPosition Position { get; private set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; private set; }
    }

    public class ISSPosition
    {
        [JsonProperty("latitude")]
        public string Latitude { get; private set; }

        [JsonProperty("longitude")]
        public string Longitude { get; private set; }
    }
}
