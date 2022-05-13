using XIVMarket.Models.Universalis;
using XIVMarket.Repository;

namespace XIVMarket.Services
{
    public class FFMarketService : IFFMarketService
    {
        private IFFMarketRepository marketRepository;
        
        
        public FFMarketService(IFFMarketRepository marketRepository)
        {
            this.marketRepository = marketRepository;           
        }
                
        public Task<MarketData> GetDataCenterMarketData(string dataCenter, int itemId)
        {     
            return marketRepository.GetDataCenterMarketData(dataCenter, itemId);
        }
    }
}