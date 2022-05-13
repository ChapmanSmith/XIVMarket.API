using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVMarket.Models
{
    public class ServerResult
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("ID")]
        public int ServerID { get; set; }

        public string Name { get; set; }

        public string DataCenter { get; set; }
    }
}
