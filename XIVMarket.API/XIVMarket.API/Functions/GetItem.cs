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
    public class GetItem
    {
        private IFFItemService itemService;

        public GetItem(IFFItemService itemService)
        {
            this.itemService = itemService;
        }

        [FunctionName("GetItem")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "item/{itemID}")] HttpRequest req, int itemID,
            ILogger log)
        {
            var itemInfo = itemService;
            var itemResult = await itemInfo.GetItem(itemID);

            return new OkObjectResult(itemResult);
        }
    }
}
