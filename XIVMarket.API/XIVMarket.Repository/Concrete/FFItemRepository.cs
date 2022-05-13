using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIVMarket.Models.XIVAPI;

namespace XIVMarket.Repository
{
    public class FFItemRepository : IFFItemRepository
    {
        private RestClient client;

        public FFItemRepository(string baseUrl)
        {
            client = new RestClient(baseUrl);
        }
        public async Task<List<Result>> GetItems(string itemName)
        {
            var request = new RestRequest($"search?indexes=item&string={itemName}&string_algo=prefix&filters=IsUntradable=0");
            request.AddHeader("Accept", "application/json");
            var response = await client.GetAsync(request);

            var desresponse = JsonConvert.DeserializeObject<ItemResults>(response.Content);

            return desresponse.Results;
        }

        public async Task<Result> GetItem(int itemID)
        {
            var itemRequest = new RestRequest($"{Environment.GetEnvironmentVariable("XIVItemDatabase")}search?indexes=item&filters=ID={itemID}");
            itemRequest.AddHeader("Accept", "application/json");
            var response = await client.GetAsync(itemRequest);

            var desresponse = JsonConvert.DeserializeObject<ItemResults>(response.Content);

            return desresponse.Results.FirstOrDefault();
        }
    }
}
