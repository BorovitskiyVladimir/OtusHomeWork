using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OtusHomeWork.Classes
{
    public class RatesInfo
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
        [JsonProperty("base")]
        public string Base { get; set; }
        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }
        [JsonProperty("rates")]
        public Dictionary<string, double> Rates { get; set; }
        public static RatesInfo FromJson(string json) => JsonConvert.DeserializeObject<RatesInfo>(json, RatesInfoJsonConverter.Settings);
    }
    internal static class RatesInfoJsonConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

