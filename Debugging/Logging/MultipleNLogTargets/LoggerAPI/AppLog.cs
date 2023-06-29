using System.Text.Json.Serialization;

namespace LoggerAPI
{
    public class AppLog
    {
        [JsonPropertyName("sourcetype")]
        public string SourceType { get; set; }
     
        [JsonPropertyName("host")]
        public string Host { get; set; }
       
        [JsonPropertyName("event")]
        public AppEvent Event { get; set; }
    }

    public class AppEvent
    {
        [JsonPropertyName("level")]
        public string Level { get; set; }
     
        [JsonPropertyName("thread")]
        public string Thread { get; set; }
     
        [JsonPropertyName("message")]
        public string Message { get; set; }
      
        [JsonPropertyName("utc")]
        public string UTC { get; set; }
    }
}
