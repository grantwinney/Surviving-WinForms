using Newtonsoft.Json;
using System.Collections.Generic;

namespace LegacySpaceLibrary
{
    public class ISSAstronauts
    {
        [JsonProperty("people")]
        public List<Astronaut> People { get; private set; }

        [JsonProperty("number")]
        public int Number { get; private set; }

        [JsonProperty("message")]
        public string Message { get; private set; }
    }

    public class Astronaut
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("craft")]
        public string Craft { get; private set; }
    }
}
