using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIVMarket.Models.Universalis;

namespace XIVMarket.Services
{
    public interface IFFMarketService
    {
        Task<MarketData> GetDataCenterMarketData(string dataCenter, int itemId);
    }
}
