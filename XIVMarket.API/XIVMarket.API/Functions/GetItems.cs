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
    public class GetItems
    {

        private IFFItemService FFItemService;

        public GetItems(IFFItemService FFItemService)
        {
            this.FFItemService = FFItemService; 
        }

        [FunctionName("GetItems")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "items/{itemKeyWord}")] HttpRequest req, string itemKeyWord,
            ILogger log)
        {            
            var itemResults = await FFItemService.GetItems(itemKeyWord);

            return new OkObjectResult(itemResults);
        }
    }
}
