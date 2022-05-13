using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using XIVMarket.Repository;
using XIVMarket.Services;

[assembly: FunctionsStartup(typeof(XIVMarket.API.Startup))]

namespace XIVMarket.API
{       
        public class Startup : FunctionsStartup
        {
            public override void Configure(IFunctionsHostBuilder builder)
            {
            builder.Services.AddTransient<IFFItemService, FFItemService>();
            builder.Services.AddTransient<IFFItemRepository>(s => new FFItemRepository(Environment.GetEnvironmentVariable("XIVItemDatabase")));
            builder.Services.AddTransient<IFFMarketService, FFMarketService>();
            builder.Services.AddTransient<IFFMarketRepository>(s => new FFMarketRepository(Environment.GetEnvironmentVariable("XIVMarketDatabase")));
            builder.Services.AddTransient<IServerDataService, ServerDataService>();
            builder.Services.AddScoped(typeof(ICosmosDBRepository<>),typeof(CosmosDBRepository<>));
            }
        }

    }

