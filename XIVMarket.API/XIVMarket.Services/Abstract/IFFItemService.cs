using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIVMarket.Models.XIVAPI;

namespace XIVMarket.Services
{
    public interface IFFItemService
    {
        Task<Result> GetItem(int itemID);
        Task<List<Result>> GetItems(string itemName);
    }
}
