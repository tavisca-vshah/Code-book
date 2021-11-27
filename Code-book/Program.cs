using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
            //Async_Thread.AsyncOrchestration();
            CheckIfParallelForeachDigestException();


            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        static void CheckIfParallelForeachDigestException()
        {
            try
            {
                Console.WriteLine("Starting exceution");
                var batches = new List<int> { 1, 2, 3, 4, 5 ,6,7,8,9,10};
                Parallel.ForEach(batches, new ParallelOptions { MaxDegreeOfParallelism = 10 }, batch =>
                {
                    Console.WriteLine($"exceuting {batch}");
                    if (batch == 10)
                    {
                        throw new Exception();
                    }
                });
            }
            catch (Exception)
            {

                Console.WriteLine("Exception occured");
            }
        }
    }
}
