using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIVMarket.Repository;
using XIVMarket.Models;

namespace XIVMarket.Services
{
    public class ServerDataService : IServerDataService
    {
        private ICosmosDBRepository<ServerResult> cosmosDBRepository;
        
        public ServerDataService(ICosmosDBRepository<ServerResult> cosmosDBRepository)
        {
            this.cosmosDBRepository = cosmosDBRepository;
            
        }
                
        public async Task<List<ServerResult>> GetServers(string dataCenterName)
        {
            
            await cosmosDBRepository.InitAsync("servers");
                        
            var servers = await cosmosDBRepository.GetItemsAsync<ServerResult>(x => x.DataCenter == dataCenterName);

            return servers.ToList();

        }
    }
}
