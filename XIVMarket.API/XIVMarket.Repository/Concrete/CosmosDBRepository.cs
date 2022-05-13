using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using XIVMarket.Models;

namespace XIVMarket.Repository
{
    public class CosmosDBRepository<T> : ICosmosDBRepository<T>
    {
        protected string Endpoint = string.Empty;
        protected string Key = string.Empty;
        protected string DatabaseId = string.Empty;
        protected string CollectionId = string.Empty;
        protected DocumentClient client;
        protected DocumentCollection collection;

        public CosmosDBRepository()
        {
            Endpoint = Environment.GetEnvironmentVariable("CosmosXIVServersEndpoint");
            Key = Environment.GetEnvironmentVariable("CosmosXIVServersKey");
            DatabaseId = Environment.GetEnvironmentVariable("CosmosXIVServersDatabaseId"); ;
            
        }

        public async Task InitAsync(string collectionId)
        {
            if (client == null)
                client = new DocumentClient(new Uri(Endpoint), Key);

            if (CollectionId != collectionId)
            {
                CollectionId = collectionId;
                collection = await client.ReadDocumentCollectionAsync(UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId));
            }
        }

        public async Task<IEnumerable<T>> GetItemsAsync<T>() where T : class
        {
            IDocumentQuery<T> query = client.CreateDocumentQuery<T>(
                UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId),
                new FeedOptions { MaxItemCount = -1, EnableCrossPartitionQuery = true })
                .AsDocumentQuery();

            List<T> results = new List<T>();
            while (query.HasMoreResults)
            {
                results.AddRange(await query.ExecuteNextAsync<T>());
            }

            return results;
        }

        public async Task<IEnumerable<T>> GetItemsAsync<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            IDocumentQuery<T> query = client.CreateDocumentQuery<T>(
                UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId),
                new FeedOptions { MaxItemCount = -1, EnableCrossPartitionQuery = true })
                .Where(predicate)
                .AsDocumentQuery();

            List<T> results = new List<T>();
            while (query.HasMoreResults)
            {
                results.AddRange(await query.ExecuteNextAsync<T>());
            }

            return results;

        }                
    }
}
