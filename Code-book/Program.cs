using System;
using Tavisca.Libraries.Configuration;

namespace Code_book
{
    class Program
    {
        static void Main(string[] args)
        {
            //string applicationName = "translation_service";
            //ISerializer jsonSerializer = new JsonSerializer();

            //var configurationProvider = new ConfigurationProviderBuilder()
            //                                .WithApplicationName(applicationName)
            //                                .WithSerializer(jsonSerializer)
            //                                .WithApiAsConfigurationStore(baseUrl)
            //                                .Build();

            //var section = "external_service_settings";
            //var key = "data_service_settings";
            //var globalConfigurationAsString = configurationProvider.GetGlobalConfigurationAsString(section, key);
            //Console.WriteLine($"Found configuration {globalConfigurationAsString}");

            //var tenantId = configurationProvider.GetTenantConfigurationAsString("1eadiecm5ret", "external_service_settings", "data_service_settings");
            Async_Thread.AsyncOrchestration();
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
