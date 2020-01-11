using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace MyFitnesLogRegisterUserJob
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
            {
                b.AddAzureStorageCoreServices();
                b.AddAzureStorage();
            });
            builder.ConfigureLogging((loggingBuilder) =>
            {
                loggingBuilder.AddConsole();
            });

            var host = builder.Build();
            using (host)
            {
                host.Run();
            }
        }
    }
}
