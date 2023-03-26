using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ProyectoFinal
{
    public class Product
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("image")]
        public Uri Images { get; set; }

    }
}
