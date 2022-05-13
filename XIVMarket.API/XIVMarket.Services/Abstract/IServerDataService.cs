using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIVMarket.Models;

namespace XIVMarket.Services
{
    public interface IServerDataService
    {
        Task<List<ServerResult>> GetServers(string dataCenterName);
    }
}
