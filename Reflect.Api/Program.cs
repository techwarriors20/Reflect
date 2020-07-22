using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;

namespace Reflect.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
            webBuilder.ConfigureAppConfiguration((hostingContext, config) =>
            {
                var settings = config.Build();
                config.AddAzureAppConfiguration(options =>
                {
                    // fetch connection string from local config. Could use KeyVault, or Secrets as well.
                    options.Connect(settings["ConnectionStrings:AppConfig"])
                           .ConfigureRefresh(refresh =>
                           {
                               // When this value changes, on the next refresh operation, the config will update all modified configs since it was last refreshed.
                               refresh.Register("Reflect.Api:Settings:Sentinel", refreshAll: true)
                                      .SetCacheExpiration(new TimeSpan(0, 5, 0));
                               // Set a timeout for the cache so that it will poll the azure config every X timespan.
                           });
                });
            })
        .UseStartup<Startup>());
    }
}
