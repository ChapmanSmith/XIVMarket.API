using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVMarket.Models.Universalis
{
    public class Listing
    {
        [JsonProperty("lastReviewTime")]
        public long LastReviewTime { get; set; }

        [JsonProperty("pricePerUnit")]
        public long PricePerUnit { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("stainID")]
        public long StainId { get; set; }

        [JsonProperty("worldName")]
        public string WorldName { get; set; }

        [JsonProperty("creatorName")]
        public string CreatorName { get; set; }

        [JsonProperty("creatorID")]
        public object CreatorId { get; set; }

        [JsonProperty("hq")]
        public bool Hq { get; set; }

        [JsonProperty("isCrafted")]
        public bool IsCrafted { get; set; }

        [JsonProperty("listingID")]
        public object ListingId { get; set; }

        [JsonProperty("materia")]
        public object[] Materia { get; set; }

        [JsonProperty("onMannequin")]
        public bool OnMannequin { get; set; }

        [JsonProperty("retainerCity")]
        public long RetainerCity { get; set; }

        [JsonProperty("retainerID")]
        public string RetainerId { get; set; }

        [JsonProperty("retainerName")]
        public string RetainerName { get; set; }

        [JsonProperty("sellerID")]
        public string SellerId { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }
}
