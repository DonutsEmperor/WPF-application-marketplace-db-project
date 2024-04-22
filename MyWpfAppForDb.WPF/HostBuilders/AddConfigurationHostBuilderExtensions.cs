﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace MyWpfAppForDb.WPF.HostBuilders
{
    internal static class AddConfigurationHostBuilderExtensions
    {
        public static IHostBuilder AddConfiguration(this IHostBuilder host)
        {
            host.ConfigureAppConfiguration(c =>
            {
                c.AddJsonFile("appsettings.json");
                c.AddEnvironmentVariables();
            });

            return host;
        }
    }
}
