using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVMarket.Models.Universalis
{
    public class MarketData
    {
        [JsonProperty("itemID")]
        public long ItemId { get; set; }

        [JsonProperty("worldID")]
        public long WorldId { get; set; }

        [JsonProperty("lastUploadTime")]
        public long LastUploadTime { get; set; }

        [JsonProperty("listings")]
        public Listing[] Listings { get; set; }

        [JsonProperty("recentHistory")]
        public RecentHistory[] RecentHistory { get; set; }

        [JsonProperty("currentAveragePrice")]
        public double CurrentAveragePrice { get; set; }

        [JsonProperty("currentAveragePriceNQ")]
        public double CurrentAveragePriceNq { get; set; }

        [JsonProperty("currentAveragePriceHQ")]
        public long CurrentAveragePriceHq { get; set; }

        [JsonProperty("regularSaleVelocity")]
        public double RegularSaleVelocity { get; set; }

        [JsonProperty("nqSaleVelocity")]
        public double NqSaleVelocity { get; set; }

        [JsonProperty("hqSaleVelocity")]
        public long HqSaleVelocity { get; set; }

        [JsonProperty("averagePrice")]
        public double AveragePrice { get; set; }

        [JsonProperty("averagePriceNQ")]
        public double AveragePriceNq { get; set; }

        [JsonProperty("averagePriceHQ")]
        public long AveragePriceHq { get; set; }

        [JsonProperty("minPrice")]
        public long MinPrice { get; set; }

        [JsonProperty("minPriceNQ")]
        public long MinPriceNq { get; set; }

        [JsonProperty("minPriceHQ")]
        public long MinPriceHq { get; set; }

        [JsonProperty("maxPrice")]
        public long MaxPrice { get; set; }

        [JsonProperty("maxPriceNQ")]
        public long MaxPriceNq { get; set; }

        [JsonProperty("maxPriceHQ")]
        public long MaxPriceHq { get; set; }

        [JsonProperty("stackSizeHistogram")]
        public Dictionary<string, long> StackSizeHistogram { get; set; }

        [JsonProperty("stackSizeHistogramNQ")]
        public Dictionary<string, long> StackSizeHistogramNq { get; set; }

        [JsonProperty("stackSizeHistogramHQ")]
        public Dictionary<string, long> StackSizeHistogramHq { get; set; }

        [JsonProperty("worldName")]
        public string WorldName { get; set; }
    }
}