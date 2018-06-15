using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Lab08LINQ.Classes
{
    public class Properties
    {
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("zip")]
        public int Zip { get; set; }
        [JsonProperty("borough")]
        public string Borough { get; set; }
        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }
        [JsonProperty("county")]
        public string County { get; set; }

    }
}
