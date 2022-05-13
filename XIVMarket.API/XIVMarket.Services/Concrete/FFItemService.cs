using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIVMarket.Models.XIVAPI;
using XIVMarket.Repository;

namespace XIVMarket.Services
{
    public class FFItemService : IFFItemService
    {
        private IFFItemRepository itemRepository;

        public FFItemService(IFFItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }
        
        public async Task<List<Result>> GetItems(string keyWord)
        {
            var items = await itemRepository.GetItems(keyWord);
            return items;
        }
        public async Task<Result> GetItem(int itemID)
        {
            var item = await itemRepository.GetItem(itemID);
            return item;
        }
    }
}
