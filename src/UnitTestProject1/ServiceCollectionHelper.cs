using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1
{
    public class ServiceCollectionHelper
    {
        private static IConfiguration GetConfiguration()
        {
            var basePath = AppContext.BaseDirectory;
            var config = new ConfigurationBuilder().SetBasePath(basePath)
                  .AddJsonFile("appsettings.json")
                  .AddJsonFile("appsettings.Development.json")
                  .Build();
            return config;
        }

        public static Tuple<IServiceCollection, IConfiguration> GetServiceCollection()
        {
            var config = GetConfiguration();
            var services = new ServiceCollection();
            services.AddSingleton(config);
            return new Tuple<IServiceCollection, IConfiguration>(services, config);
        }
    }
}
