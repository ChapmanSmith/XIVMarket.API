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
    public class GetServers
    {
        private IServerDataService serverDataService;

        public GetServers(IServerDataService serverDataService)
        {
            this.serverDataService = serverDataService;
        }

        [FunctionName("GetServers")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "DataCenter/{DataCenterName}")] HttpRequest req, string dataCenterName,
            ILogger log)
        {   
            var serverDataResults = await serverDataService.GetServers(dataCenterName);

            return new OkObjectResult(serverDataResults);
        }
    }
}
