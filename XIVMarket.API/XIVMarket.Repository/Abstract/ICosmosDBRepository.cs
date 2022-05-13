using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using XIVMarket.Models;

namespace XIVMarket.Repository
{
    public interface ICosmosDBRepository<T>
    {
        Task InitAsync(string collectionId);
        Task<IEnumerable<T>> GetItemsAsync<T>() where T : class;
        Task<IEnumerable<T>> GetItemsAsync<T>(Expression<Func<T, bool>> predicate) where T : class;
                   
    }
}
