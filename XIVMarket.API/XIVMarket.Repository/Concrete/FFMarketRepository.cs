using Newtonsoft.Json;
using RestSharp;
using XIVMarket.Models.Universalis;

namespace XIVMarket.Repository
{
    public class FFMarketRepository : IFFMarketRepository
    {
        private RestClient client;

        public FFMarketRepository(string baseUrl)
        {
            this.client = new RestClient(baseUrl);
        }
        public async Task<MarketData> GetDataCenterMarketData(string dataCenter, int itemId)
        {
            var request = new RestRequest($"/api/v2/{dataCenter}/{itemId}");
            request.AddHeader("Accept", "application/json");
            var response = await client.GetAsync(request);

            return JsonConvert.DeserializeObject<MarketData>(response.Content);
        }
                
    }
}