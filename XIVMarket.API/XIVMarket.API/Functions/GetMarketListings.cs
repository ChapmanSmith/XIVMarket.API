using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using XIVMarket.Services;

namespace XIVMarket.API.Functions
{
    public class GetMarketListings
    {
        private IFFMarketService FFMarketService;

        public GetMarketListings(IFFMarketService FFMarketService)
        {
            this.FFMarketService = FFMarketService; 
        }
        
        [FunctionName("GetMarketListings")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "dc/{dataCenterId}/listings/{ItemID}")] HttpRequest req, string dataCenterId, int ItemID,
            ILogger log)
        {
            var marketResults = await FFMarketService.GetDataCenterMarketData(dataCenterId, ItemID);
                    
            return new OkObjectResult(marketResults);
        }
    }
}
